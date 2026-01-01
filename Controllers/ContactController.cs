using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using System.Text.Json;
using MarmaraHijyen.Models;

namespace MarmaraHijyen.Controllers
{
    public class ContactController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        // GET: /Contact
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Contact/SendMessage
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMessage(ContactFormModel model, string? website, string? formTimestamp)
        {
            // Honeypot kontrolü (bot koruması)
            if (!string.IsNullOrEmpty(website))
            {
                // Bot yakalandı, sessizce başarılı gibi göster
                TempData["Success"] = "Mesajınız başarıyla gönderildi!";
                return RedirectToAction("Index");
            }

            // Timestamp kontrolü (3 saniyeden hızlı doldurulmuşsa bot)
            if (!string.IsNullOrEmpty(formTimestamp))
            {
                if (long.TryParse(formTimestamp, out long timestamp))
                {
                    var now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    if ((now - timestamp) < 3000)
                    {
                        TempData["Success"] = "Mesajınız başarıyla gönderildi!";
                        return RedirectToAction("Index");
                    }
                }
            }

            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Lütfen tüm alanları doğru şekilde doldurun.";
                return View("Index", model);
            }

            try
            {
                // Kullanıcı bilgilerini al
                var ipAddress = GetClientIpAddress();
                var userAgent = Request.Headers["User-Agent"].ToString();
                var browserInfo = ParseUserAgent(userAgent);
                var geoInfo = await GetGeoLocationAsync(ipAddress);

                // SMTP ayarlarını al
                var smtpHost = _configuration["SmtpSettings:Host"] ?? "smtp.gmail.com";
                var smtpPort = int.Parse(_configuration["SmtpSettings:Port"] ?? "587");
                var smtpUser = _configuration["SmtpSettings:Username"] ?? "";
                var smtpPass = _configuration["SmtpSettings:Password"] ?? "";
                var toEmail = _configuration["SmtpSettings:ToEmail"];

                // Mail içeriği oluştur
                var subject = $"🔔 Yeni Teklif Talebi: {model.Subject} - {model.FullName}";

                var body = GenerateEmailTemplate(model, ipAddress, geoInfo, browserInfo);

                // Mail gönder
                using (var client = new SmtpClient(smtpHost, smtpPort))
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(smtpUser, smtpPass);

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(smtpUser, "Marmara Hijyen Web"),
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true
                    };

                    mailMessage.To.Add(toEmail);
                    mailMessage.ReplyToList.Add(new MailAddress(model.Email, model.FullName));

                    await client.SendMailAsync(mailMessage);
                }

                TempData["Success"] = "Mesajınız başarıyla gönderildi! En kısa sürede size dönüş yapacağız.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mail gönderme hatası: {ex.Message}");
                TempData["Error"] = "Mesaj gönderilirken bir hata oluştu. Lütfen daha sonra tekrar deneyin veya bizi telefonla arayın.";
                return View("Index", model);
            }
        }

        // IP Adresini Al
        private string GetClientIpAddress()
        {
            var ipAddress = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "Bilinmiyor";

            // Proxy arkasındaysa gerçek IP'yi al
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                ipAddress = Request.Headers["X-Forwarded-For"].ToString().Split(',')[0].Trim();
            }
            else if (Request.Headers.ContainsKey("X-Real-IP"))
            {
                ipAddress = Request.Headers["X-Real-IP"].ToString();
            }

            // Localhost kontrolü
            if (ipAddress == "::1" || ipAddress == "127.0.0.1")
            {
                ipAddress = "Localhost (Geliştirme)";
            }

            return ipAddress;
        }

        // IP'den Konum Bilgisi Al
        private async Task<GeoInfo> GetGeoLocationAsync(string ipAddress)
        {
            var geoInfo = new GeoInfo();

            try
            {
                if (ipAddress.Contains("Localhost") || ipAddress == "::1" || ipAddress == "127.0.0.1")
                {
                    geoInfo.Country = "Türkiye";
                    geoInfo.City = "İstanbul";
                    geoInfo.Region = "İstanbul";
                    geoInfo.Isp = "Localhost";
                    return geoInfo;
                }

                var client = _httpClientFactory.CreateClient();
                client.Timeout = TimeSpan.FromSeconds(5);

                // ip-api.com ücretsiz API kullan
                var response = await client.GetAsync($"http://ip-api.com/json/{ipAddress}?fields=status,country,regionName,city,isp,org,query&lang=tr");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonSerializer.Deserialize<JsonElement>(json);

                    if (data.GetProperty("status").GetString() == "success")
                    {
                        geoInfo.Country = data.GetProperty("country").GetString() ?? "Bilinmiyor";
                        geoInfo.City = data.GetProperty("city").GetString() ?? "Bilinmiyor";
                        geoInfo.Region = data.GetProperty("regionName").GetString() ?? "Bilinmiyor";
                        geoInfo.Isp = data.GetProperty("isp").GetString() ?? "Bilinmiyor";
                        geoInfo.Org = data.GetProperty("org").GetString() ?? "";
                    }
                }
            }
            catch
            {
                // Hata olursa varsayılan değerler
            }

            return geoInfo;
        }

        // User Agent Parse
        private BrowserInfo ParseUserAgent(string userAgent)
        {
            var info = new BrowserInfo();

            // Tarayıcı
            if (userAgent.Contains("Edg/")) info.Browser = "Microsoft Edge";
            else if (userAgent.Contains("Chrome/")) info.Browser = "Google Chrome";
            else if (userAgent.Contains("Firefox/")) info.Browser = "Mozilla Firefox";
            else if (userAgent.Contains("Safari/") && !userAgent.Contains("Chrome")) info.Browser = "Safari";
            else if (userAgent.Contains("Opera") || userAgent.Contains("OPR/")) info.Browser = "Opera";
            else info.Browser = "Diğer";

            // İşletim Sistemi
            if (userAgent.Contains("Windows NT 10")) info.OS = "Windows 10/11";
            else if (userAgent.Contains("Windows NT 6.3")) info.OS = "Windows 8.1";
            else if (userAgent.Contains("Windows NT 6.1")) info.OS = "Windows 7";
            else if (userAgent.Contains("Mac OS X")) info.OS = "macOS";
            else if (userAgent.Contains("Linux")) info.OS = "Linux";
            else if (userAgent.Contains("Android")) info.OS = "Android";
            else if (userAgent.Contains("iPhone") || userAgent.Contains("iPad")) info.OS = "iOS";
            else info.OS = "Diğer";

            // Cihaz
            if (userAgent.Contains("Mobile") || userAgent.Contains("Android") || userAgent.Contains("iPhone"))
                info.Device = "📱 Mobil";
            else if (userAgent.Contains("Tablet") || userAgent.Contains("iPad"))
                info.Device = "📱 Tablet";
            else
                info.Device = "💻 Masaüstü";

            return info;
        }

        // Email Template Oluştur
        private string GenerateEmailTemplate(ContactFormModel model, string ipAddress, GeoInfo geo, BrowserInfo browser)
        {
            var subjectIcon = model.Subject switch
            {
                "Genel Bilgi" => "📋",
                "Fiyat Teklifi" => "💰",
                "Private Label" => "🏷️",
                "İhracat" => "🌍",
                "Numune Talebi" => "📦",
                "Distribütörlük" => "🤝",
                "Teknik Destek" => "🔧",
                _ => "📝"
            };

            var priorityColor = model.Subject switch
            {
                "Fiyat Teklifi" => "#10b981",
                "Private Label" => "#f59e0b",
                "İhracat" => "#3b82f6",
                "Distribütörlük" => "#8b5cf6",
                _ => "#6b7280"
            };

            return $@"
<!DOCTYPE html>
<html lang='tr'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
</head>
<body style='margin: 0; padding: 0; font-family: -apple-system, BlinkMacSystemFont, ""Segoe UI"", Roboto, ""Helvetica Neue"", Arial, sans-serif; background-color: #f3f4f6;'>
    <table width='100%' cellpadding='0' cellspacing='0' style='background-color: #f3f4f6; padding: 40px 20px;'>
        <tr>
            <td align='center'>
                <table width='600' cellpadding='0' cellspacing='0' style='background-color: #ffffff; border-radius: 16px; overflow: hidden; box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);'>
                    
                    <!-- Header -->
                    <tr>
                        <td style='background: linear-gradient(135deg, #1e40af 0%, #3b82f6 50%, #60a5fa 100%); padding: 40px 30px; text-align: center;'>
                            <h1 style='margin: 0; color: #ffffff; font-size: 28px; font-weight: 700;'>
                                📧 Yeni İletişim Formu
                            </h1>
                            <p style='margin: 10px 0 0 0; color: rgba(255,255,255,0.9); font-size: 16px;'>
                                Marmara Hijyen Web Sitesi
                            </p>
                        </td>
                    </tr>

                    <!-- Priority Badge -->
                    <tr>
                        <td style='padding: 25px 30px 0 30px;'>
                            <table width='100%' cellpadding='0' cellspacing='0'>
                                <tr>
                                    <td>
                                        <span style='display: inline-block; background-color: {priorityColor}; color: white; padding: 8px 20px; border-radius: 50px; font-size: 14px; font-weight: 600;'>
                                            {subjectIcon} {model.Subject}
                                        </span>
                                    </td>
                                    <td align='right'>
                                        <span style='color: #6b7280; font-size: 14px;'>
                                            🕐 {DateTime.Now:dd MMM yyyy, HH:mm}
                                        </span>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <!-- Kişi Bilgileri -->
                    <tr>
                        <td style='padding: 25px 30px;'>
                            <table width='100%' cellpadding='0' cellspacing='0' style='background: linear-gradient(135deg, #eff6ff 0%, #dbeafe 100%); border-radius: 12px; padding: 25px;'>
                                <tr>
                                    <td>
                                        <h2 style='margin: 0 0 20px 0; color: #1e40af; font-size: 18px; font-weight: 700; border-bottom: 2px solid #3b82f6; padding-bottom: 10px;'>
                                            👤 Müşteri Bilgileri
                                        </h2>
                                        
                                        <table width='100%' cellpadding='8' cellspacing='0'>
                                            <tr>
                                                <td width='140' style='color: #64748b; font-size: 14px; font-weight: 600;'>Ad Soyad:</td>
                                                <td style='color: #1e293b; font-size: 15px; font-weight: 700;'>{model.FullName}</td>
                                            </tr>
                                            <tr>
                                                <td style='color: #64748b; font-size: 14px; font-weight: 600;'>Firma:</td>
                                                <td style='color: #1e293b; font-size: 15px;'>{(string.IsNullOrEmpty(model.Company) ? "<span style='color:#94a3b8;'>Belirtilmedi</span>" : model.Company)}</td>
                                            </tr>
                                            <tr>
                                                <td style='color: #64748b; font-size: 14px; font-weight: 600;'>E-posta:</td>
                                                <td style='font-size: 15px;'><a href='mailto:{model.Email}' style='color: #2563eb; text-decoration: none; font-weight: 600;'>{model.Email}</a></td>
                                            </tr>
                                            <tr>
                                                <td style='color: #64748b; font-size: 14px; font-weight: 600;'>Telefon:</td>
                                                <td style='font-size: 15px;'><a href='tel:{model.Phone}' style='color: #2563eb; text-decoration: none; font-weight: 600;'>{model.Phone}</a></td>
                                            </tr>
                                            <tr>
                                                <td style='color: #64748b; font-size: 14px; font-weight: 600;'>Ülke (Form):</td>
                                                <td style='color: #1e293b; font-size: 15px;'>{(string.IsNullOrEmpty(model.Country) ? "<span style='color:#94a3b8;'>Belirtilmedi</span>" : model.Country)}</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <!-- Mesaj -->
                    <tr>
                        <td style='padding: 0 30px 25px 30px;'>
                            <table width='100%' cellpadding='0' cellspacing='0' style='background-color: #fefce8; border-left: 4px solid #eab308; border-radius: 0 12px 12px 0; padding: 20px 25px;'>
                                <tr>
                                    <td>
                                        <h3 style='margin: 0 0 15px 0; color: #854d0e; font-size: 16px; font-weight: 700;'>
                                            💬 Mesaj İçeriği
                                        </h3>
                                        <p style='margin: 0; color: #1e293b; font-size: 15px; line-height: 1.8; white-space: pre-wrap;'>{model.Message}</p>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <!-- Hızlı Aksiyon Butonları -->
                    <tr>
                        <td style='padding: 0 30px 25px 30px;'>
                            <table width='100%' cellpadding='0' cellspacing='0'>
                                <tr>
                                    <td align='center'>
                                        <a href='mailto:{model.Email}?subject=RE: {model.Subject} - Marmara Hijyen' style='display: inline-block; background: linear-gradient(135deg, #1e40af 0%, #3b82f6 100%); color: white; padding: 14px 35px; border-radius: 50px; text-decoration: none; font-weight: 600; font-size: 15px; margin: 5px;'>
                                            ✉️ E-posta Gönder
                                        </a>
                                        <a href='tel:{model.Phone}' style='display: inline-block; background: linear-gradient(135deg, #059669 0%, #10b981 100%); color: white; padding: 14px 35px; border-radius: 50px; text-decoration: none; font-weight: 600; font-size: 15px; margin: 5px;'>
                                            📞 Hemen Ara
                                        </a>
                                        <a href='https://wa.me/{model.Phone?.Replace(" ", "").Replace("+", "")}' style='display: inline-block; background: linear-gradient(135deg, #128c7e 0%, #25d366 100%); color: white; padding: 14px 35px; border-radius: 50px; text-decoration: none; font-weight: 600; font-size: 15px; margin: 5px;'>
                                            💬 WhatsApp
                                        </a>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <!-- Teknik Bilgiler -->
                    <tr>
                        <td style='padding: 0 30px 30px 30px;'>
                            <table width='100%' cellpadding='0' cellspacing='0' style='background-color: #f8fafc; border-radius: 12px; padding: 20px;'>
                                <tr>
                                    <td>
                                        <h3 style='margin: 0 0 15px 0; color: #475569; font-size: 14px; font-weight: 700; text-transform: uppercase; letter-spacing: 1px;'>
                                            🔍 Teknik Detaylar
                                        </h3>
                                        
                                        <table width='100%' cellpadding='6' cellspacing='0' style='font-size: 13px;'>
                                            <tr>
                                                <td width='50%'>
                                                    <table cellpadding='4' cellspacing='0'>
                                                        <tr>
                                                            <td style='color: #94a3b8;'>🌍 Konum:</td>
                                                            <td style='color: #475569; font-weight: 600;'>{geo.City}, {geo.Region}, {geo.Country}</td>
                                                        </tr>
                                                        <tr>
                                                            <td style='color: #94a3b8;'>🔗 IP Adresi:</td>
                                                            <td style='color: #475569; font-family: monospace;'>{ipAddress}</td>
                                                        </tr>
                                                        <tr>
                                                            <td style='color: #94a3b8;'>📡 ISP:</td>
                                                            <td style='color: #475569;'>{geo.Isp}</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td width='50%'>
                                                    <table cellpadding='4' cellspacing='0'>
                                                        <tr>
                                                            <td style='color: #94a3b8;'>{browser.Device} Cihaz:</td>
                                                            <td style='color: #475569;'>{browser.OS}</td>
                                                        </tr>
                                                        <tr>
                                                            <td style='color: #94a3b8;'>🌐 Tarayıcı:</td>
                                                            <td style='color: #475569;'>{browser.Browser}</td>
                                                        </tr>
                                                        <tr>
                                                            <td style='color: #94a3b8;'>📅 Tarih:</td>
                                                            <td style='color: #475569;'>{DateTime.Now:dd.MM.yyyy HH:mm:ss}</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>

                    <!-- Footer -->
                    <tr>
                        <td style='background-color: #1e293b; padding: 25px 30px; text-align: center;'>
                            <p style='margin: 0 0 10px 0; color: #94a3b8; font-size: 13px;'>
                                Bu mesaj <strong style='color: #60a5fa;'>marmarahijyen.com</strong> iletişim formundan gönderilmiştir.
                            </p>
                            <p style='margin: 0; color: #64748b; font-size: 12px;'>
                                © {DateTime.Now.Year} Marmara Hijyen Ürünleri San. ve Dış Tic. Ltd. Şti.
                            </p>
                        </td>
                    </tr>

                </table>
            </td>
        </tr>
    </table>
</body>
</html>";
        }
    }

    // Yardımcı Sınıflar
    public class GeoInfo
    {
        public string Country { get; set; } = "Bilinmiyor";
        public string City { get; set; } = "Bilinmiyor";
        public string Region { get; set; } = "Bilinmiyor";
        public string Isp { get; set; } = "Bilinmiyor";
        public string Org { get; set; } = "";
    }

    public class BrowserInfo
    {
        public string Browser { get; set; } = "Bilinmiyor";
        public string OS { get; set; } = "Bilinmiyor";
        public string Device { get; set; } = "💻 Masaüstü";
    }
}