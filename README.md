# 🏢 Marmara Hijyen - Kurumsal Web Sitesi

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?logo=dotnet)
![License](https://img.shields.io/badge/License-MIT-green)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-7952B3?logo=bootstrap)
![Status](https://img.shields.io/badge/Status-Production-success)

> **Marmara Hijyen**, 2015'ten bu yana hijyen, medikal ve temizlik ürünleri üretimi yapan kurumsal firmanın modern, responsive ve SEO uyumlu web sitesidir. MyFix ve CleanPad markaları ile Türkiye ve uluslararası pazarlara hizmet vermektedir.

---

## 🌟 Özellikler

### 🎨 Kullanıcı Arayüzü
- ✨ Modern ve responsive tasarım (Bootstrap 5.3)
- 📱 Mobil uyumlu (Mobile-first yaklaşım)
- 🎭 AOS (Animate On Scroll) animasyonları
- 🖼️ Lightbox ile ürün görselleri görüntüleme
- 🎨 Gradient efektler ve modern UI/UX

### 📧 İletişim Formu
- 🛡️ Bot koruması (Honeypot + Timestamp kontrolü)
- 📨 SMTP ile profesyonel email gönderimi
- 🌍 IP tabanlı geolocation (ip-api.com entegrasyonu)
- 🖥️ User Agent parsing (Tarayıcı, işletim sistemi, cihaz tespiti)
- 📊 Detaylı HTML email template'leri
- ⚡ Anti-forgery token koruması
- 🔗 Hızlı aksiyon butonları (Email, Telefon, WhatsApp)

### 🎯 İş Özellikleri
- 🏷️ MyFix & CleanPad marka tanıtımları
- 📦 Ürün kataloğu (Underpad, Hasta Altı Bezi, Temizleme Mendilleri)
- 🌍 İhracat ve Private Label hizmetleri
- 🏥 Kurumsal tedarik çözümleri
- 📱 Responsive ürün kartları
- 🔍 SEO optimize edilmiş içerik

### 🔒 Güvenlik
- 🤖 Honeypot bot koruması
- ⏱️ Timestamp tabanlı hız kontrolü
- 🔐 ValidateAntiForgeryToken
- 🛡️ Model validation
- 🌐 XSS koruması

---

## 🗂️ Proje Yapısı

```
MarmaraHijyen/
├── Controllers/
│   ├── HomeController.cs          # Ana sayfa controller
│   └── ContactController.cs       # İletişim formu controller
├── Models/
│   ├── ContactFormModel.cs        # Form model
│   ├── GeoInfo.cs                 # Geolocation model
│   └── BrowserInfo.cs             # Browser info model
├── Views/
│   ├── Home/
│   │   └── Index.cshtml          # Ana sayfa
│   ├── Contact/
│   │   └── Index.cshtml          # İletişim sayfası
│   └── Products/
│       └── Index.cshtml          # Ürünler sayfası
├── wwwroot/
│   ├── css/
│   │   └── site.css              # Ana stil dosyası
│   ├── js/
│   │   └── site.js               # JavaScript dosyaları
│   └── Image/
│       ├── 1.png                 # Hasta altı bezi
│       ├── 11.png                # Underpad
│       ├── 13.png                # CleanPad
│       ├── 16.png                # Vücut temizleme
│       ├── urt.jpg               # Hero image
│       ├── sev.jpeg              # Kurumsal
│       ├── unnamed.jpg           # İhracat
│       └── bb.jpg                # Private label
├── appsettings.json              # Konfigürasyon
├── Program.cs                    # Ana program
└── Startup.cs                    # Uygulama başlangıcı
```

---

## 🛠️ Teknolojiler

### Backend
- **Framework:** ASP.NET Core 8.0 MVC
- **Language:** C# 12
- **Email:** System.Net.Mail (SMTP)
- **HTTP Client:** IHttpClientFactory
- **Validation:** Data Annotations
- **Serialization:** System.Text.Json

### Frontend
- **CSS Framework:** Bootstrap 5.3
- **Icons:** Bootstrap Icons
- **Animations:** AOS (Animate On Scroll)
- **Layout:** Responsive Grid System
- **Components:** Cards, Badges, Buttons, Modals

### Entegrasyonlar
- **Geolocation API:** ip-api.com
- **Email Service:** SMTP (Gmail, custom SMTP servers)
- **WhatsApp:** wa.me link integration
- **Phone:** tel: protocol

---

## ⚙️ Kurulum

### Gereksinimler
- .NET 8.0 SDK veya üzeri
- Visual Studio 2022 veya VS Code
- SMTP hesabı (Gmail, Outlook, vb.)

### 1️⃣ Projeyi Klonla
```bash
git clone https://github.com/yourusername/marmara-hijyen.git
cd marmara-hijyen
```

### 2️⃣ Bağımlılıkları Yükle
```bash
dotnet restore
```

### 3️⃣ Konfigürasyonu Ayarla

`appsettings.json` dosyasını oluştur veya düzenle:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "SmtpSettings": {
    "Host": "smtp.gmail.com",
    "Port": "587",
    "Username": "your-email@gmail.com",
    "Password": "your-app-password",
    "ToEmail": "info@marmarahijyen.com"
  }
}
```

> ⚠️ **Önemli Notlar:**
> - Gmail kullanıyorsanız, [2FA App Password](https://support.google.com/accounts/answer/185833) oluşturmanız gerekir
> - `appsettings.json` dosyasını `.gitignore`'a eklemeyi unutmayın
> - Production'da environment variables kullanın

### 4️⃣ Uygulamayı Çalıştır
```bash
dotnet run
```

Veya Visual Studio'da `F5` tuşuna basın.

Tarayıcınızda: `https://localhost:5001` veya `http://localhost:5000` adresine gidin.

---

## 🚀 Kullanım

### Ana Sayfa
1. Tarayıcıda projeyi açın
2. Hero section'da firmanın tanıtımını görün
3. MyFix ve CleanPad marka kartlarını inceleyin
4. Ürün kataloğuna göz atın
5. Kurumsal tedarik, İhracat ve Private Label bölümlerini okuyun

### İletişim Formu
1. Ana sayfadan **"Teklif Alın"** butonuna tıklayın
2. Formu doldurun:
   - **Ad Soyad** (zorunlu)
   - **Email** (zorunlu, geçerli format)
   - **Telefon** (zorunlu)
   - **Firma** (opsiyonel)
   - **Ülke** (opsiyonel)
   - **Konu** (dropdown'dan seçim yapın)
   - **Mesaj** (zorunlu)
3. **"Gönder"** butonuna tıklayın
4. ✅ Başarılı mesajı alın

### Konu Seçenekleri
- 📋 Genel Bilgi
- 💰 Fiyat Teklifi
- 🏷️ Private Label
- 🌍 İhracat
- 📦 Numune Talebi
- 🤝 Distribütörlük
- 🔧 Teknik Destek

### Email Template Özellikleri
Gönderilen email şunları içerir:
- 📧 Profesyonel HTML tasarım
- 📊 Müşteri bilgileri (Ad, Firma, İletişim)
- 💬 Mesaj içeriği
- 🌍 Teknik detaylar:
  - IP Adresi
  - Konum (Şehir, Ülke, ISP)
  - Tarayıcı bilgisi
  - İşletim sistemi
  - Cihaz türü (Mobil/Masaüstü)
- 🔗 Hızlı aksiyon butonları:
  - ✉️ Email Gönder
  - 📞 Telefon Ara
  - 💬 WhatsApp Mesaj

### Bot Koruması Nasıl Çalışır?
1. **Honeypot Alanı:** Kullanıcıya görünmeyen `website` alanı. Botlar bunu doldurur, gerçek kullanıcılar dolduramaz.
2. **Timestamp Kontrolü:** Form minimum 3 saniyede doldurulmalı. Daha hızlı gönderimler bot olarak işaretlenir.
3. **Anti-CSRF Token:** Her form gönderiminde benzersiz token doğrulaması yapılır.

---

## 🎯 Öne Çıkan Kod Parçaları

### Bot Koruması Implementation
```csharp
// Honeypot kontrolü (bot yakalama)
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
```

### IP Adresi ve Geolocation
```csharp
// IP Adresini Al (Proxy desteği ile)
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

    return ipAddress;
}

// IP'den Konum Bilgisi Al
private async Task<GeoInfo> GetGeoLocationAsync(string ipAddress)
{
    var client = _httpClientFactory.CreateClient();
    client.Timeout = TimeSpan.FromSeconds(5);

    var response = await client.GetAsync(
        $"http://ip-api.com/json/{ipAddress}?fields=status,country,regionName,city,isp,org,query&lang=tr"
    );

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
        }
    }
    
    return geoInfo;
}
```

### User Agent Parsing
```csharp
private BrowserInfo ParseUserAgent(string userAgent)
{
    var info = new BrowserInfo();

    // Tarayıcı Tespiti
    if (userAgent.Contains("Edg/")) info.Browser = "Microsoft Edge";
    else if (userAgent.Contains("Chrome/")) info.Browser = "Google Chrome";
    else if (userAgent.Contains("Firefox/")) info.Browser = "Mozilla Firefox";
    else if (userAgent.Contains("Safari/") && !userAgent.Contains("Chrome")) info.Browser = "Safari";
    else if (userAgent.Contains("Opera") || userAgent.Contains("OPR/")) info.Browser = "Opera";
    else info.Browser = "Diğer";

    // İşletim Sistemi Tespiti
    if (userAgent.Contains("Windows NT 10")) info.OS = "Windows 10/11";
    else if (userAgent.Contains("Mac OS X")) info.OS = "macOS";
    else if (userAgent.Contains("Linux")) info.OS = "Linux";
    else if (userAgent.Contains("Android")) info.OS = "Android";
    else if (userAgent.Contains("iPhone") || userAgent.Contains("iPad")) info.OS = "iOS";
    else info.OS = "Diğer";

    // Cihaz Türü Tespiti
    if (userAgent.Contains("Mobile") || userAgent.Contains("Android") || userAgent.Contains("iPhone"))
        info.Device = "📱 Mobil";
    else if (userAgent.Contains("Tablet") || userAgent.Contains("iPad"))
        info.Device = "📱 Tablet";
    else
        info.Device = "💻 Masaüstü";

    return info;
}
```

### SMTP Email Gönderimi
```csharp
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
```

---

## 📊 Email Template Görünümü

```
┌─────────────────────────────────────────────────────────┐
│         📧 Yeni İletişim Formu                          │
│         Marmara Hijyen Web Sitesi                       │
├─────────────────────────────────────────────────────────┤
│ 💰 Fiyat Teklifi              🕐 01 Jan 2026, 14:30    │
├─────────────────────────────────────────────────────────┤
│ 👤 Müşteri Bilgileri                                    │
│ ───────────────────────────────                         │
│   Ad Soyad:    Ali Yılmaz                              │
│   Firma:       ABC Medikal Ltd. Şti.                   │
│   E-posta:     ali@example.com                         │
│   Telefon:     +90 555 123 45 67                       │
│   Ülke:        Türkiye                                 │
├─────────────────────────────────────────────────────────┤
│ 💬 Mesaj İçeriği                                        │
│ ───────────────────                                     │
│   "Hastane için toplu hasta altı bezi alımı            │
│    yapmak istiyoruz. Fiyat teklifi alabilir miyim?"   │
├─────────────────────────────────────────────────────────┤
│        [✉️ E-posta Gönder] [📞 Hemen Ara]              │
│              [💬 WhatsApp Mesaj]                        │
├─────────────────────────────────────────────────────────┤
│ 🔍 Teknik Detaylar                                      │
│ ──────────────────                                      │
│   🌍 Konum:       İstanbul, İstanbul, Türkiye          │
│   🔗 IP Adresi:   185.123.45.67                        │
│   📡 ISP:         Turk Telekom                         │
│   💻 Cihaz:       Windows 10/11                        │
│   🌐 Tarayıcı:    Google Chrome                        │
│   📅 Tarih:       01.01.2026 14:30:15                  │
└─────────────────────────────────────────────────────────┘
```

---

## 🔧 Yapılandırma Detayları

### SMTP Ayarları

| Parametre | Açıklama | Örnek Değer |
|-----------|----------|-------------|
| `Host` | SMTP sunucu adresi | smtp.gmail.com |
| `Port` | SMTP port numarası | 587 (TLS) veya 465 (SSL) |
| `Username` | Gönderici email adresi | noreply@marmarahijyen.com |
| `Password` | Email şifresi veya App Password | **************** |
| `ToEmail` | Alıcı email adresi | info@marmarahijyen.com |
| `EnableSsl` | SSL/TLS kullanımı | true |

### Popüler SMTP Sağlayıcıları

**Gmail:**
```json
{
  "Host": "smtp.gmail.com",
  "Port": "587",
  "EnableSsl": true
}
```

**Outlook/Hotmail:**
```json
{
  "Host": "smtp-mail.outlook.com",
  "Port": "587",
  "EnableSsl": true
}
```

**SendGrid:**
```json
{
  "Host": "smtp.sendgrid.net",
  "Port": "587",
  "Username": "apikey",
  "Password": "your-sendgrid-api-key"
}
```

**AWS SES:**
```json
{
  "Host": "email-smtp.us-east-1.amazonaws.com",
  "Port": "587",
  "Username": "your-smtp-username",
  "Password": "your-smtp-password"
}
```

### Geolocation API
- **Sağlayıcı:** [ip-api.com](http://ip-api.com)
- **Plan:** Ücretsiz (45 istek/dakika)
- **Timeout:** 5 saniye
- **Dil:** Türkçe (lang=tr)
- **Dönen Alanlar:** country, regionName, city, isp, org, query
- **Localhost Durumu:** Otomatik "İstanbul, Türkiye" değeri atanır

---

## 📈 İyileştirme ve Geliştirme Önerileri

### 🔒 Güvenlik İyileştirmeleri
- [ ] **reCAPTCHA v3** entegrasyonu (görünmez bot koruması)
- [ ] **Rate Limiting** - IP bazlı istek sınırlaması (örn: 5 istek/saat)
- [ ] **Email Verification** - Kullanıcıya doğrulama maili gönderme
- [ ] **HTTPS Zorunluluğu** - Production'da sadece HTTPS
- [ ] **Content Security Policy (CSP)** header'ları
- [ ] **SQL Injection** koruması (şu an Entity Framework kullanılmıyor ama gelecekte)

### ⚡ Performans İyileştirmeleri
- [ ] **Background Jobs** (Hangfire/Quartz.NET) - Email'leri async gönderme
- [ ] **Redis Cache** - Geolocation sonuçlarını cache'leme
- [ ] **CDN Entegrasyonu** - Görseller için CloudFlare/AWS CloudFront
- [ ] **Image Optimization** - WebP formatı, lazy loading
- [ ] **Minification** - CSS/JS minify ve bundling
- [ ] **Database Connection Pooling** (veritabanı eklenirse)
- [ ] **Response Compression** - Gzip/Brotli

### 🌟 Yeni Özellikler
- [ ] **Çoklu Dil Desteği** (i18n) - TR, EN, AR, RU
- [ ] **Admin Panel** - Form gönderimlerini görüntüleme ve yönetme
- [ ] **Email Template Seçenekleri** - Farklı template'ler arasında seçim
- [ ] **Google Analytics** - Kullanıcı davranışı takibi
- [ ] **Live Chat** (Tawk.to, Intercom, Crisp)
- [ ] **WhatsApp Chat Widget** - Direkt WhatsApp iletişimi
- [ ] **File Upload** - Ürün talebi için dosya ekleme
- [ ] **Newsletter** - Email listesi toplama
- [ ] **Blog Modülü** - SEO için içerik üretimi
- [ ] **Ürün Karşılaştırma** - Ürünleri yan yana görüntüleme
- [ ] **Online Teklif Hesaplama** - Anlık fiyat hesaplama
- [ ] **Sipariş Takibi** - Sipariş durumu sorgulama

### 📊 Analytics & Tracking
- [ ] **Google Analytics 4** entegrasyonu
- [ ] **Google Tag Manager**
- [ ] **Facebook Pixel**
- [ ] **LinkedIn Insight Tag**
- [ ] **Hotjar** - Heatmap ve kullanıcı kaydı
- [ ] **Custom Event Tracking** - Form gönderimleri, button tıklamaları

### 🎨 UI/UX İyileştirmeleri
- [ ] **Dark Mode** - Koyu tema desteği
- [ ] **Accessibility** (a11y) - WCAG 2.1 uyumluluğu
- [ ] **Progressive Web App (PWA)** - Offline çalışma
- [ ] **Skeleton Loaders** - Yükleme animasyonları
- [ ] **Toast Notifications** - Kullanıcı geri bildirimleri
- [ ] **Form Validation** - Real-time validation mesajları

### 🧪 Testing & Quality
- [ ] **Unit Tests** - xUnit/NUnit ile birim testleri
- [ ] **Integration Tests** - API endpoint testleri
- [ ] **UI Tests** - Selenium/Playwright ile otomatik testler
- [ ] **Load Testing** - JMeter/k6 ile yük testleri
- [ ] **Code Coverage** - %80+ kod kapsama hedefi

---

## 🐛 Bilinen Sorunlar ve Çözümler

### Email İle İlgili
- ⚠️ **Outlook 2007-2010'da responsive bozulma**
  - **Çözüm:** Email template'inde table-based layout kullanılıyor ancak eski Outlook sürümleri bazı CSS3 özelliklerini desteklemiyor
  - **Workaround:** `mso-` prefix'li CSS kullanarak Outlook özel stilleri eklenebilir

- ⚠️ **SMTP timeout durumu**
  - **Sorun:** Email gönderimi sırasında timeout olursa retry mekanizması yok
  - **Çözüm:** Background job sistemi (Hangfire) ile retry logic eklenmeli

### Geolocation İle İlgili
- ⚠️ **Localhost'ta geolocation**
  - **Sorun:** Localhost (127.0.0.1, ::1) için API çağrısı yapılamıyor
  - **Mevcut Çözüm:** Otomatik "İstanbul, Türkiye" değeri atanıyor
  - **Gelecek:** Development ortamında test IP'si kullanılabilir

- ⚠️ **API Rate Limit**
  - **Sorun:** ip-api.com ücretsiz planda 45 istek/dakika limiti var
  - **Çözüm:** Redis cache ile sonuçları cache'lemek veya ücretli plana geçmek

### Browser Compatibility
- ⚠️ **IE 11 desteği yok**
  - **Durum:** Bootstrap 5.3 IE 11'i desteklemiyor
  - **Çözüm:** Gerekirse Bootstrap 4.6 kullanılabilir veya polyfill eklenebilir

---

## 🧪 Test Senaryoları

### Manuel Test Checklist

**Form Testi:**
- [ ] Tüm alanlar dolu - başarılı gönderim
- [ ] Email formatı geçersiz - hata mesajı
- [ ] Zorunlu alanlar boş - validation hatası
- [ ] Honeypot alanı dolu - sessiz reddetme
- [ ] 3 saniyeden hızlı gönderim - bot algılama
- [ ] CSRF token olmadan gönderim - güvenlik hatası

**Email Testi:**
- [ ] Gmail'de görünüm kontrolü
- [ ] Outlook'ta görünüm kontrolü
- [ ] Mobil email client'da görünüm
- [ ] Spam folder kontrolü
- [ ] Email'deki linklerin çalışması

**Responsive Testi:**
- [ ] Desktop (1920x1080)
- [ ] Laptop (1366x768)
- [ ] Tablet (768x1024)
- [ ] Mobile (375x667)

**Browser Testi:**
- [ ] Chrome
- [ ] Firefox
- [ ] Safari
- [ ] Edge
- [ ] Samsung Internet

---

## 📚 API Dokümantasyonu

### Geolocation API Response

**Request:**
```
GET http://ip-api.com/json/185.123.45.67?fields=status,country,regionName,city,isp,org,query&lang=tr
```

**Response:**
```json
{
  "status": "success",
  "country": "Türkiye",
  "regionName": "İstanbul",
  "city": "İstanbul",
  "isp": "Turk Telekom",
  "org": "Turk Telekom",
  "query": "185.123.45.67"
}
```

### Model Yapıları

**ContactFormModel:**
```csharp
public class ContactFormModel
{
    [Required(ErrorMessage = "Ad Soyad zorunludur")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Email zorunludur")]
    [EmailAddress(ErrorMessage = "Geçerli bir email giriniz")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Telefon zorunludur")]
    public string Phone { get; set; }

    public string Company { get; set; }
    public string Country { get; set; }

    [Required(ErrorMessage = "Konu seçimi zorunludur")]
    public string Subject { get; set; }

    [Required(ErrorMessage = "Mesaj zorunludur")]
    [MinLength(10, ErrorMessage = "Mesaj en az 10 karakter olmalıdır")]
    public string Message { get; set; }
}
```

**GeoInfo:**
```csharp
public class GeoInfo
{
    public string Country { get; set; } = "Bilinmiyor";
    public string City { get; set; } = "Bilinmiyor";
    public string Region { get; set; } = "Bilinmiyor";
    public string Isp { get; set; } = "Bilinmiyor";
    public string Org { get; set; } = "";
}
```

**BrowserInfo:**
```csharp
public class BrowserInfo
{
    public string Browser { get; set; } = "Bilinmiyor";
    public string OS { get; set; } = "Bilinmiyor";
    public string Device { get; set; } = "💻 Masaüstü";
}
```

---

## 🚀 Deployment

### Azure App Service
```bash
# Azure CLI ile deploy
az webapp up --name marmara-hijyen --resource-group production-rg --runtime "DOTNET|8.0"

# App Settings ekle
az webapp config appsettings set --name marmara-hijyen --resource-group production-rg --settings \
  SmtpSettings__Host="smtp.gmail.com" \
  SmtpSettings__Port="587" \
  SmtpSettings__Username="your-email@gmail.com" \
  SmtpSettings__Password="your-app-password" \
  SmtpSettings__ToEmail="info@marmarahijyen.com"
```

### Docker
```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["MarmaraHijyen.csproj", "./"]
RUN dotnet restore "MarmaraHijyen.csproj"
COPY . .
RUN dotnet build "MarmaraHijyen.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MarmaraHijyen.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MarmaraHijyen.dll"]
```

**Docker Compose:**
```yaml
version: '3.8'
services:
  web:
    build: .
    ports:
      - "8080:80"
      - "8443:443"
    environment:
      - ASPNETCORE_ENVIRONMENT=Production
      - SmtpSettings__Host=smtp.gmail.com
      - SmtpSettings__Port=587
      - SmtpSettings__Username=${SMTP_USERNAME}
      - SmtpSettings__Password=${SMTP_PASSWORD}
      - SmtpSettings__ToEmail=${SMTP_TO_EMAIL}
    restart: unless-stopped
```

### IIS (Windows Server)
1. Web Server (IIS) rolünü yükle
2. .NET 8.0 Hosting Bundle'ı indir ve kur
3. IIS Manager'da yeni site oluştur
4. `web.config` dosyasını kontrol et
5. Application Pool'u `.NET CLR Version: No Managed Code` olarak ayarla

---

## 🤝 Katkıda Bulunma

Katkılarınızı bekliyoruz! 🎉

### Katkı Süreci

1. **Fork** edin (sağ üstteki Fork butonu)
2. **Feature branch** oluşturun
   ```bash
   git checkout -b feature/amazing-feature
   ```
3. **Commit** edin (Conventional Commits formatında)
   ```bash
   git commit -m 'feat: Add amazing feature'
   ```
4. **Push** edin
   ```bash
   git push origin feature/amazing-feature
   ```
5. **Pull Request** açın

### Commit Mesajı Formatı

[Conventional Commits](https://www.conventionalcommits.org/) standardını kullanıyoruz:

- `feat:` Yeni özellik
- `fix:` Bug düzeltme
- `docs:` Dokümantasyon değişikliği
- `style:` Kod formatı (whitespace, formatting, noktalı virgül, vb.)
- `refactor:` Kod iyileştirme (ne bug fix ne de feature)
- `perf:` Performans iyileştirme
- `test:` Test ekleme veya düzeltme
- `chore:` Build süreci, yardımcı araçlar, kütüphane güncellemeleri

**Örnekler:**
```
feat: Add email verification system
fix: Resolve SMTP timeout issue
docs: Update installation guide in README
style: Format code with Prettier
refactor: Simplify geolocation logic
perf: Optimize image loading
test: Add unit tests for ContactController
chore: Update Bootstrap to 5.3.3
```

### Code Review Süreci

Tüm pull request'ler aşağıdaki kriterleri karşılamalıdır:

- ✅ Build başarılı
- ✅ Testler geçiyor
- ✅ Code review onayı alınmış
- ✅ Conventional Commits formatında
- ✅ Çakışma (conflict) yok

---

## 📄 Lisans

Bu proje **MIT Lisansı** altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakın.

```
MIT License

Copyright (c) 2025 Marmara Hijyen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

---

## 📬 İletişim

### Şirket İletişim
- 🌐 **Web Sitesi:** [marmarahijyen.com](https://marmarahijyen.com)
- 📧 **Email:** info@marmarahijyen.com
- 📞 **Telefon:** +90 212 690 00 01
- 📱 **WhatsApp:** [Mesaj Gönder](https://wa.me/902126900001)
- 🏢 **Adres:** İstanbul, Türkiye

### Sosyal Medya
- 📘 Facebook: [/marmarahijyen](https://facebook.com/marmarahijyen)
- 📸 Instagram: [@marmarahijyen](https://instagram.com/marmarahijyen)
- 💼 LinkedIn: [Marmara Hijyen](https://linkedin.com/company/marmarahijyen)
- 🐦 Twitter: [@marmarahijyen](https://twitter.com/marmarahijyen)

### Geliştirici İletişim
- 👨‍💻 **GitHub:** [@yourusername](https://github.com/yourusername)
- 🐞 **Bug Bildirimi:** [Issues Sekmesi](https://github.com/yourusername/marmara-hijyen/issues)
- 💬 **Tartışmalar:** [Discussions Sekmesi](https://github.com/yourusername/marmara-hijyen/discussions)
- 📧 **Developer Email:** dev@marmarahijyen.com

---

## 🎖️ Teşekkürler

Bu projeyi mümkün kılan harika açık kaynak projelere teşekkürler:

### Frameworks & Libraries
- [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet) - Modern web framework
- [Bootstrap](https://getbootstrap.com) - Responsive CSS framework
- [Bootstrap Icons](https://icons.getbootstrap.com) - 2000+ ücretsiz icon
- [AOS](https://michalsnik.github.io/aos/) - Scroll animasyonları

### APIs & Services
- [ip-api.com](http://ip-api.com) - Ücretsiz IP geolocation API
- [Gmail SMTP](https://support.google.com/mail/answer/7126229) - Email gönderimi

### Tools & Resources
- [Visual Studio](https://visualstudio.microsoft.com) - IDE
- [Git](https://git-scm.com) - Version control
- [GitHub](https://github.com) - Code hosting

### Contributors
Tüm katkıda bulunanlara teşekkürler! 🙏

<a href="https://github.com/yourusername/marmara-hijyen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=yourusername/marmara-hijyen" />
</a>

---

## 📊 Proje İstatistikleri

![GitHub repo size](https://img.shields.io/github/repo-size/yourusername/marmara-hijyen)
![GitHub code size](https://img.shields.io/github/languages/code-size/yourusername/marmara-hijyen)
![GitHub language count](https://img.shields.io/github/languages/count/yourusername/marmara-hijyen)
![GitHub top language](https://img.shields.io/github/languages/top/yourusername/marmara-hijyen)

---

## 🗺️ Roadmap

### Q1 2026
- [x] Temel web sitesi yapısı
- [x] İletişim formu ve email sistemi
- [x] Bot koruması implementasyonu
- [ ] reCAPTCHA v3 entegrasyonu
- [ ] Admin panel geliştirme

### Q2 2026
- [ ] Çoklu dil desteği (EN, AR, RU)
- [ ] Blog modülü ekleme
- [ ] Newsletter sistemi
- [ ] Google Analytics entegrasyonu
- [ ] Live chat widget

### Q3 2026
- [ ] E-ticaret modülü (online sipariş)
- [ ] Müşteri portalı
- [ ] Sipariş takip sistemi
- [ ] Online ödeme entegrasyonu
- [ ] Mobile app (React Native)

### Q4 2026
- [ ] AI-powered chatbot
- [ ] Advanced analytics dashboard
- [ ] CRM entegrasyonu
- [ ] Automated email campaigns
- [ ] Performance optimizations

---

## 📸 Ekran Görüntüleri

### Ana Sayfa
![Ana Sayfa](docs/screenshots/home.png)

### İletişim Formu
![İletişim Formu](docs/screenshots/contact.png)

### Email Template
![Email Template](docs/screenshots/email-template.png)

### Ürünler
![Ürünler](docs/screenshots/products.png)

### Responsive Design
![Responsive](docs/screenshots/responsive.png)

---

## 🔗 Faydalı Linkler

### Dokümantasyon
- [ASP.NET Core Docs](https://docs.microsoft.com/aspnet/core)
- [Bootstrap Docs](https://getbootstrap.com/docs)
- [C# Language Reference](https://docs.microsoft.com/dotnet/csharp)

### Tutorials
- [ASP.NET Core MVC Tutorial](https://docs.microsoft.com/aspnet/core/tutorials/first-mvc-app)
- [Bootstrap 5 Tutorial](https://www.w3schools.com/bootstrap5)
- [Email Template Design](https://templates.mailchimp.com)

### Tools
- [Email HTML Tester](https://www.htmlemailcheck.com/check)
- [Responsive Tester](https://responsivedesignchecker.com)
- [SEO Checker](https://seobility.net/en/seocheck)

---

## ❓ SSS (Sık Sorulan Sorular)

**S: Gmail'de "Less secure apps" hatası alıyorum?**
A: Google artık "less secure apps" desteğini kaldırdı. [App Password](https://support.google.com/accounts/answer/185833) oluşturmanız gerekiyor.

**S: Email'ler spam klasörüne düşüyor?**
A: SPF, DKIM ve DMARC kayıtlarını domain'iniz için yapılandırın. Ayrıca gönderici email adresini domain'inizle eşleştirin.

**S: Localhost'ta geolocation çalışmıyor?**
A: Localhost için otomatik olarak "İstanbul, Türkiye" değeri atanıyor. Production'da gerçek IP'ler için düzgün çalışacaktır.

**S: Form 3 saniyede doldurulamıyor mu?**
A: Bot koruması için minimum 3 saniye bekleme süresi var. Bu süre kodda değiştirilebilir (ContactController.cs, satır 40).

**S: Hangi .NET versiyonunu kullanmalıyım?**
A: .NET 8.0 LTS (Long Term Support) kullanmanızı öneriyoruz. .NET 9 kullanabilirsiniz ancak LTS değil.

**S: Email template'i nasıl özelleştirebilirim?**
A: `ContactController.cs` içindeki `GenerateEmailTemplate` metodunu düzenleyebilirsiniz.

---

<p align="center">
  <img src="https://img.shields.io/badge/Made%20with-❤️-red" alt="made with love" />
  <img src="https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?logo=dotnet" alt="aspnet" />
  <img src="https://img.shields.io/badge/Bootstrap-5.3-7952B3?logo=bootstrap" alt="bootstrap" />
  <img src="https://img.shields.io/badge/C%23-12-239120?logo=csharp" alt="csharp" />
  <img src="https://img.shields.io/badge/Status-Production%20Ready-success" alt="status" />
</p>

<p align="center">
  <strong>⭐ Projeyi beğendiyseniz yıldız vermeyi unutmayın!</strong>
</p>

<p align="center">
  <sub>Built with 💙 by Marmara Hijyen Development Team</sub>
</p>

---

**Son Güncelleme:** 01 Ocak 2026  
**Versiyon:** 1.0.0  
**Durum:** 🟢 Production Ready
