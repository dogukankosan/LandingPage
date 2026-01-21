using Microsoft.AspNetCore.Mvc;

namespace MarmaraHijyen.Controllers
{
    public class ProductsController : Controller
    {
        // Ana ürünler sayfası
        public IActionResult Index()
        {
            return View();
        }

        // Ürün detay sayfası - slug ile
        [Route("Products/Detail/{slug}")]
        public IActionResult Detail(string slug)
        {
            // Ürün bilgilerini slug'a göre al
            var product = GetProductBySlug(slug);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        private ProductDetailViewModel GetProductBySlug(string slug)
        {
            // Tüm ürünleri tanımla
            var products = new Dictionary<string, ProductDetailViewModel>
            {
                // CleanPad Hasta Bezleri
                {
                    "cleanpad-hasta-bezi-xl-30",
                    new ProductDetailViewModel
                    {
                        Slug = "cleanpad-hasta-bezi-xl-30",
                        Name = "CleanPad Yetişkin Hasta Bezi XL",
                        Brand = "CleanPad",
                        Category = "Medikal",
                        SubCategory = "Yetişkin Hasta Bezi",
                        PackSize = "30'lu Paket",
                        Size = "XL (Extra Large)",
                        MainImage = "/Image/22.png",
                        Images = new List<string> { "/Image/22.png" },
                        ShortDescription = "Dermatolojik test onaylı, yüksek emicilik kapasiteli hasta bezi",
                        Description = @"CleanPad XL hasta bezi, yetişkin hastaların konforlu ve hijyenik bakımı için özel olarak tasarlanmıştır. 
                                       Yüksek emicilik kapasitesi sayesinde uzun süreli kullanıma uygundur. Dermatolojik olarak test edilmiş, 
                                       cilde zarar vermez. Nefes alabilen yapısı ile cildin havalanmasını sağlar.",
                        Features = new List<string>
                        {
                            "Dermatolojik Test Onaylı",
                            "Yüksek Emicilik Kapasitesi",
                            "Nefes Alabilen Yapı",
                            "Sızıntı Önleyici Yan Bantlar",
                            "Yumuşak İç Yüzey",
                            "Koku Kontrol Sistemi",
                            "Pratik Kullanım",
                            "30'lu Ekonomik Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Beden", "XL (Extra Large)" },
                            { "Paket İçeriği", "30 Adet" },
                            { "Emicilik Kapasitesi", "Yüksek (1200ml+)" },
                            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
                            { "Bel Çevresi", "1270 cm" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Hastaneler",
                            "Bakım Evleri",
                            "Evde Hasta Bakımı",
                            "Yaşlı Bakım Merkezleri"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
                    "cleanpad-hasta-bezi-xl-10",
                    new ProductDetailViewModel
                    {
                        Slug = "cleanpad-hasta-bezi-xl-10",
                        Name = "CleanPad Yetişkin Hasta Bezi XL",
                        Brand = "CleanPad",
                        Category = "Medikal",
                        SubCategory = "Yetişkin Hasta Bezi",
                        PackSize = "10'lu Paket",
                        Size = "XL (Extra Large)",
                        MainImage = "/Image/21.png",
                        Images = new List<string> { "/Image/21.png" },
                        ShortDescription = "Islaklık göstergeli, pratik kullanımlık hasta bezi",
                        Description = @"CleanPad XL hasta bezi 10'lu paket, pratik kullanım için ideal boyuttadır. 
                                       Islaklık göstergesi sayesinde değişim zamanını kolayca takip edebilirsiniz. 
                                       Hastaneler ve evde hasta bakımı için uygundur.",
                        Features = new List<string>
                        {
                            "Islaklık Göstergesi",
                            "Dermatolojik Test Onaylı",
                            "Hızlı Emilim",
                            "Sızıntı Önleyici",
                            "Yumuşak Doku",
                            "Pratik Paket Boyutu",
                            "Koku Nötralizasyon",
                            "10'lu Ekonomik Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Beden", "XL (Extra Large)" },
                            { "Paket İçeriği", "10 Adet" },
                            { "Emicilik Kapasitesi", "Yüksek (1200ml+)" },
                            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
                            { "Bel Çevresi", "120-170 cm" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Hastaneler",
                            "Klinikler",
                            "Evde Hasta Bakımı",
                            "Seyahat"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
                    "cleanpad-hasta-bezi-l-30",
                    new ProductDetailViewModel
                    {
                        Slug = "cleanpad-hasta-bezi-l-30",
                        Name = "CleanPad Yetişkin Hasta Bezi L",
                        Brand = "CleanPad",
                        Category = "Medikal",
                        SubCategory = "Yetişkin Hasta Bezi",
                        PackSize = "30'lu Paket",
                        Size = "L (Large)",
                        MainImage = "/Image/20.png",
                        Images = new List<string> { "/Image/20.png" },
                        ShortDescription = "Yumuşak ve nefes alabilen yapıya sahip hasta bezi",
                        Description = @"CleanPad L hasta bezi, orta beden kullanıcılar için tasarlanmıştır. 
                                       Yumuşak iç yüzeyi ve nefes alabilen yapısı ile maksimum konfor sağlar.",
                        Features = new List<string>
                        {
                            "Yumuşak & Nefes Alan",
                            "Dermatolojik Test Onaylı",
                            "Hızlı Emilim Teknolojisi",
                            "Anatomik Kesim",
                            "Koku Kontrolü",
                            "Elastik Yan Bantlar",
                            "Ekonomik 30'lu Paket",
                            "Cilde Zarar Vermez"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Beden", "L (Large)" },
                            { "Paket İçeriği", "30 Adet" },
                            { "Emicilik Kapasitesi", "Orta-Yüksek (1000ml+)" },
                            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
                            { "Bel Çevresi", "100-150 cm" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Hastaneler",
                            "Bakım Evleri",
                            "Evde Hasta Bakımı"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
                    "cleanpad-hasta-bezi-l-10",
                    new ProductDetailViewModel
                    {
                        Slug = "cleanpad-hasta-bezi-l-10",
                        Name = "CleanPad Yetişkin Hasta Bezi L",
                        Brand = "CleanPad",
                        Category = "Medikal",
                        SubCategory = "Yetişkin Hasta Bezi",
                        PackSize = "10'lu Paket",
                        Size = "L (Large)",
                        MainImage = "/Image/19.png",
                        Images = new List<string> { "/Image/19.png" },
                        ShortDescription = "Pratik paket boyutunda hasta bezi",
                        Description = @"CleanPad L hasta bezi 10'lu paket, kısa süreli kullanım ve deneme için ideal boyuttadır. 
                                       Yumuşak iç yüzeyi ve nefes alabilen yapısı ile konfor sağlar.",
                        Features = new List<string>
                        {
                            "Pratik 10'lu Paket",
                            "Yumuşak & Nefes Alan",
                            "Dermatolojik Test Onaylı",
                            "Hızlı Emilim",
                            "Anatomik Kesim",
                            "Koku Kontrolü",
                            "Deneme Paketi",
                            "Ekonomik"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Beden", "L (Large)" },
                            { "Paket İçeriği", "10 Adet" },
                            { "Emicilik Kapasitesi", "Orta-Yüksek (1000ml+)" },
                            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
                            { "Bel Çevresi", "100-150 cm" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Hastaneler",
                            "Evde Bakım",
                            "Seyahat",
                            "Deneme Kullanımı"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
                    "cleanpad-hasta-bezi-m-30",
                    new ProductDetailViewModel
                    {
                        Slug = "cleanpad-hasta-bezi-m-30",
                        Name = "CleanPad Yetişkin Hasta Bezi M",
                        Brand = "CleanPad",
                        Category = "Medikal",
                        SubCategory = "Yetişkin Hasta Bezi",
                        PackSize = "30'lu Paket",
                        Size = "M (Medium)",
                        MainImage = "/Image/18.png",
                        Images = new List<string> { "/Image/18.png" },
                        ShortDescription = "Orta beden için konforlu hasta bezi",
                        Description = @"CleanPad M hasta bezi, orta beden kullanıcılar için tasarlanmış konforlu üründür. 
                                       Yüksek emicilik kapasitesi ve yumuşak yapısı ile günlük kullanıma uygundur.",
                        Features = new List<string>
                        {
                            "M Beden",
                            "Yüksek Emicilik",
                            "Dermatolojik Test Onaylı",
                            "Yumuşak İç Yüzey",
                            "Nefes Alabilen Yapı",
                            "Anatomik Tasarım",
                            "Koku Kontrolü",
                            "30'lu Ekonomik Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Beden", "M (Medium)" },
                            { "Paket İçeriği", "30 Adet" },
                            { "Emicilik Kapasitesi", "Orta-Yüksek (800ml+)" },
                            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
                            { "Bel Çevresi", "85-125 cm" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Hastaneler",
                            "Bakım Evleri",
                            "Evde Hasta Bakımı"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
                    "cleanpad-hasta-bezi-m-10",
                    new ProductDetailViewModel
                    {
                        Slug = "cleanpad-hasta-bezi-m-10",
                        Name = "CleanPad Yetişkin Hasta Bezi M",
                        Brand = "CleanPad",
                        Category = "Medikal",
                        SubCategory = "Yetişkin Hasta Bezi",
                        PackSize = "10'lu Paket",
                        Size = "M (Medium)",
                        MainImage = "/Image/17.png",
                        Images = new List<string> { "/Image/17.png" },
                        ShortDescription = "Pratik paket M beden hasta bezi",
                        Description = @"CleanPad M hasta bezi 10'lu paket, orta beden kullanıcılar için pratik paket boyutudur. 
                                       Kısa süreli kullanım ve deneme amaçlı idealdir.",
                        Features = new List<string>
                        {
                            "Pratik 10'lu Paket",
                            "M Beden",
                            "Yüksek Emicilik",
                            "Yumuşak Doku",
                            "Dermatolojik Test Onaylı",
                            "Koku Kontrolü",
                            "Deneme Paketi",
                            "Ekonomik"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Beden", "M (Medium)" },
                            { "Paket İçeriği", "10 Adet" },
                            { "Emicilik Kapasitesi", "Orta-Yüksek (800ml+)" },
                            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
                            { "Bel Çevresi", "85-115 cm" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Evde Bakım",
                            "Seyahat",
                            "Deneme Kullanımı"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
                    "cleanpad-hasta-bezi-s-30",
                    new ProductDetailViewModel
                    {
                        Slug = "cleanpad-hasta-bezi-s-30",
                        Name = "CleanPad Yetişkin Hasta Bezi S",
                        Brand = "CleanPad",
                        Category = "Medikal",
                        SubCategory = "Yetişkin Hasta Bezi",
                        PackSize = "30'lu Paket",
                        Size = "S (Small)",
                        MainImage = "/Image/16.png",
                        Images = new List<string> { "/Image/16.png" },
                        ShortDescription = "Küçük beden için hasta bezi",
                        Description = @"CleanPad S hasta bezi, küçük beden kullanıcılar için özel olarak tasarlanmıştır. 
                                       Kompakt yapısı ile konforlu kullanım sağlar.",
                        Features = new List<string>
                        {
                            "S Beden",
                            "Kompakt Tasarım",
                            "Yüksek Emicilik",
                            "Dermatolojik Test Onaylı",
                            "Yumuşak Doku",
                            "Nefes Alabilen",
                            "Koku Kontrolü",
                            "30'lu Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Beden", "S (Small)" },
                            { "Paket İçeriği", "30 Adet" },
                            { "Emicilik Kapasitesi", "Orta (700ml+)" },
                            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
                            { "Bel Çevresi", "50-90 cm" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Hastaneler",
                            "Bakım Evleri",
                            "Evde Hasta Bakımı"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                // CleanPad Underpad Ürünleri
                {
                    "cleanpad-underpad-60x90",
                    new ProductDetailViewModel
                    {
                        Slug = "cleanpad-underpad-60x90",
                        Name = "CleanPad Underpad (Yatak Koruyucu)",
                        Brand = "CleanPad",
                        Category = "Medikal",
                        SubCategory = "Underpad (Yatak Koruyucu Örtü)",
                        PackSize = "30'lu Paket",
                        Size = "60 × 90 cm",
                        MainImage = "/Image/14.png",
                        Images = new List<string> { "/Image/14.png" },
                        ShortDescription = "Yüksek emiciliğe sahip yatak koruyucu örtü",
                        Description = @"CleanPad Underpad, yatak ve döşemeleri korumak için tasarlanmış tek kullanımlık koruyucu örtüdür. 
                                       Yüksek emicilik kapasitesi ile sıvıları hızla emer ve yüzeyin kuru kalmasını sağlar.",
                        Features = new List<string>
                        {
                            "Yüksek Emicilik",
                            "Su Geçirmez Alt Tabaka",
                            "Yumuşak Üst Yüzey",
                            "Hızlı Emilim",
                            "Kaymaz Alt Yüzey",
                            "Hijyenik Tek Kullanımlık",
                            "Hastane Standartlarında",
                            "30'lu Ekonomik Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Ebat", "60 × 90 cm" },
                            { "Paket İçeriği", "30 Adet" },
                            { "Emicilik Kapasitesi", "Yüksek" },
                            { "Malzeme", "Nonwoven, Fluff Pulp, SAP, PE Film" },
                            { "Kullanım", "Tek Kullanımlık" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Hastaneler",
                            "Klinikler",
                            "Evde Hasta Bakımı",
                            "Yaşlı Bakım Merkezleri"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
                    "cleanpad-underpad-90x180",
                    new ProductDetailViewModel
                    {
                        Slug = "cleanpad-underpad-90x180",
                        Name = "CleanPad Underpad XL (Yatak Koruyucu)",
                        Brand = "CleanPad",
                        Category = "Medikal",
                        SubCategory = "Underpad (Yatak Koruyucu Örtü)",
                        PackSize = "30'lu Paket",
                        Size = "90 × 180 cm",
                        MainImage = "/Image/15.png",
                        Images = new List<string> { "/Image/15.png" },
                        ShortDescription = "Ekstra büyük boy, ekstra emici yatak koruyucu",
                        Description = @"CleanPad Underpad XL, geniş koruma alanı gerektiren durumlar için tasarlanmış ekstra büyük boy yatak koruyucudur. 
                                       Ekstra emicilik kapasitesi ile uzun süreli kullanıma uygundur.",
                        Features = new List<string>
                        {
                            "XL Ebat (90×180)",
                            "Ekstra Emici",
                            "Geniş Koruma Alanı",
                            "Su Geçirmez",
                            "Yumuşak Yüzey",
                            "Hızlı Kuruma",
                            "Profesyonel Kullanım",
                            "30'lu Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Ebat", "90 × 180 cm" },
                            { "Paket İçeriği", "30 Adet" },
                            { "Emicilik Kapasitesi", "Ekstra Yüksek" },
                            { "Malzeme", "Nonwoven, Fluff Pulp, SAP, PE Film" },
                            { "Kullanım", "Tek Kullanımlık" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Hastaneler",
                            "Ameliyathaneler",
                            "Doğum Üniteleri",
                            "Bakım Evleri"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                // MyFix Hasta Bezleri
                {
                    "myfix-hasta-bezi-xl-30",
                    new ProductDetailViewModel
                    {
                        Slug = "myfix-hasta-bezi-xl-30",
                        Name = "MyFix Yetişkin Hasta Bezi XL",
                        Brand = "MyFix",
                        Category = "Medikal",
                        SubCategory = "Yetişkin Hasta Bezi",
                        PackSize = "30'lu Paket",
                        Size = "XL (Extra Large)",
                        MainImage = "/Image/7.png",
                        Images = new List<string> { "/Image/7.png" },
                        ShortDescription = "Islaklık göstergeli premium hasta bezi",
                        Description = @"MyFix XL hasta bezi, yetişkin hastaların konforu için özel olarak tasarlanmış premium kalite üründür. 
                                       Islaklık göstergesi sayesinde değişim zamanını kolayca takip edebilirsiniz.",
                        Features = new List<string>
                        {
                            "Islaklık Göstergesi",
                            "Premium Kalite",
                            "Ultra Emici Çekirdek",
                            "Dermatolojik Test Onaylı",
                            "Anatomik Tasarım",
                            "Koku Nötralizasyon",
                            "Elastik Bantlar",
                            "30'lu Ekonomik Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Beden", "XL (Extra Large)" },
                            { "Paket İçeriği", "30 Adet" },
                            { "Emicilik Kapasitesi", "Yüksek (1200ml+)" },
                            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
                            { "Bel Çevresi", "120-170 cm" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Hastaneler",
                            "Özel Bakım",
                            "Evde Hasta Bakımı",
                            "Rehabilitasyon Merkezleri"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
                    "myfix-hasta-bezi-xl-12",
                    new ProductDetailViewModel
                    {
                        Slug = "myfix-hasta-bezi-xl-12",
                        Name = "MyFix Yetişkin Hasta Bezi XL",
                        Brand = "MyFix",
                        Category = "Medikal",
                        SubCategory = "Yetişkin Hasta Bezi",
                        PackSize = "12'li Paket",
                        Size = "XL (Extra Large)",
                        MainImage = "/Image/6.png",
                        Images = new List<string> { "/Image/6.png" },
                        ShortDescription = "Islaklık göstergeli pratik paket hasta bezi",
                        Description = @"MyFix XL hasta bezi 12'li paket, kısa süreli kullanım ve deneme amaçlı ideal paket boyutudur. 
                                       Islaklık göstergesi ve yüksek kalite standartları ile güvenilir kullanım sağlar.",
                        Features = new List<string>
                        {
                            "Islaklık Göstergesi",
                            "Pratik Paket Boyutu",
                            "Yüksek Emicilik",
                            "Dermatolojik Test Onaylı",
                            "Koku Kontrolü",
                            "Yumuşak Doku",
                            "Deneme Paketi",
                            "12'li Ekonomik Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Beden", "XL (Extra Large)" },
                            { "Paket İçeriği", "12 Adet" },
                            { "Emicilik Kapasitesi", "Yüksek (1200ml+)" },
                            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
                            { "Bel Çevresi", "120-170 cm" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Evde Bakım",
                            "Seyahat",
                            "Deneme Kullanımı",
                            "Kısa Süreli İhtiyaç"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
                    "myfix-hasta-bezi-l-30",
                    new ProductDetailViewModel
                    {
                        Slug = "myfix-hasta-bezi-l-30",
                        Name = "MyFix Yetişkin Hasta Bezi L",
                        Brand = "MyFix",
                        Category = "Medikal",
                        SubCategory = "Yetişkin Hasta Bezi",
                        PackSize = "30'lu Paket",
                        Size = "L (Large)",
                        MainImage = "/Image/5.png",
                        Images = new List<string> { "/Image/5.png" },
                        ShortDescription = "Orta beden için ideal hasta bezi",
                        Description = @"MyFix L hasta bezi, orta beden kullanıcılar için tasarlanmış konforlu ve güvenilir üründür. 
                                       Yüksek emicilik ve yumuşak yapısı ile günlük kullanıma uygundur.",
                        Features = new List<string>
                        {
                            "L Beden",
                            "Konforlu Kullanım",
                            "Yüksek Emicilik",
                            "Yumuşak İç Yüzey",
                            "Sızıntı Önleyici",
                            "Koku Kontrolü",
                            "Elastik Bantlar",
                            "30'lu Ekonomik Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Beden", "L (Large)" },
                            { "Paket İçeriği", "30 Adet" },
                            { "Emicilik Kapasitesi", "Yüksek (1000ml+)" },
                            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
                            { "Bel Çevresi", "100-150 cm" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Hastaneler",
                            "Bakım Evleri",
                            "Evde Hasta Bakımı"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
    "myfix-hasta-bezi-m-30",
    new ProductDetailViewModel
    {
        Slug = "myfix-hasta-bezi-m-30",
        Name = "Yetişkin Hasta Bezi",
        Brand = "MyFix",
        Category = "Medikal",
        SubCategory = "Yetişkin Hasta Bezi",
        PackSize = "30'lu Paket",
        Size = "M (Medium)",
        MainImage = "/Image/3.png",
        Images = new List<string> { "/Image/3.png" },
        ShortDescription = "Orta beden için hasta bezi - Islaklık göstergeli",
        Description = @"MyFix M hasta bezi, orta beden kullanıcılar için özel olarak tasarlanmıştır. 
                       Islaklık göstergesi ile değişim zamanını belirlemek kolaylaşır. 
                       Anatomik yapısı ve yüksek emicilik özelliği ile günlük konfor sağlar.",
        Features = new List<string>
        {
            "M Beden (Medium)",
            "Islaklık Göstergesi",
            "Anatomik Kesim",
            "Yüksek Emicilik",
            "Dermatolojik Test Onaylı",
            "Nefes Alabilen Yapı",
            "Koku Kontrolü",
            "Sızıntı Önleyici Bariyerler",
            "30'lu Paket"
        },
        Specifications = new Dictionary<string, string>
        {
            { "Beden", "M (Medium)" },
            { "Paket İçeriği", "30 Adet" },
            { "Özellik", "Islaklık Göstergesi" },
            { "Emicilik Kapasitesi", "Orta-Yüksek (800ml+)" },
            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
            { "Bel Çevresi", "85-115 cm" },
            { "Sertifikalar", "CE, ISO 9001" },
            { "Marka", "MyFix" }
        },
        UsageAreas = new List<string>
        {
            "Hastaneler",
            "Evde Hasta Bakımı",
            "Bakım Merkezleri",
            "Yaşlı Bakım Evleri"
        },
        IsAvailableForExport = true,
        IsPrivateLabelAvailable = true
    }
},
                {
                    "myfix-hasta-bezi-l-12",
                    new ProductDetailViewModel
                    {
                        Slug = "myfix-hasta-bezi-l-12",
                        Name = "MyFix Yetişkin Hasta Bezi L",
                        Brand = "MyFix",
                        Category = "Medikal",
                        SubCategory = "Yetişkin Hasta Bezi",
                        PackSize = "12'li Paket",
                        Size = "L (Large)",
                        MainImage = "/Image/4.png",
                        Images = new List<string> { "/Image/4.png" },
                        ShortDescription = "Pratik paket L beden hasta bezi",
                        Description = @"MyFix L hasta bezi 12'li paket, orta beden kullanıcılar için pratik paket boyutudur. 
                                       Islaklık göstergesi ile değişim zamanını kolayca takip edebilirsiniz.",
                        Features = new List<string>
                        {
                            "Islaklık Göstergesi",
                            "Pratik 12'li Paket",
                            "L Beden",
                            "Yüksek Emicilik",
                            "Dermatolojik Test Onaylı",
                            "Koku Kontrolü",
                            "Yumuşak Doku",
                            "Deneme Paketi"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Beden", "L (Large)" },
                            { "Paket İçeriği", "12 Adet" },
                            { "Emicilik Kapasitesi", "Yüksek (1000ml+)" },
                            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
                            { "Bel Çevresi", "100-150 cm" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Evde Bakım",
                            "Seyahat",
                            "Deneme Kullanımı",
                            "Kısa Süreli İhtiyaç"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
             {
    "myfix-hasta-bezi-m-12",
    new ProductDetailViewModel
    {
        Slug = "myfix-hasta-bezi-m-12",
        Name = "Yetişkin Hasta Bezi",
        Brand = "MyFix",
        Category = "Medikal",
        SubCategory = "Yetişkin Hasta Bezi",
        PackSize = "12'li Paket",
        Size = "M (Medium)",
        MainImage = "/Image/2.png",
        Images = new List<string> { "/Image/2.png" },
        ShortDescription = "Pratik paket M beden hasta bezi - Islaklık göstergeli",
        Description = @"MyFix M hasta bezi 12'li paket, orta beden kullanıcılar için pratik paket boyutudur. 
                       Islaklık göstergesi ile değişim zamanını belirlemek kolaylaşır.
                       Kısa süreli kullanım, deneme ve seyahat için idealdir.",
        Features = new List<string>
        {
            "Pratik 12'li Paket",
            "M Beden (Medium)",
            "Islaklık Göstergesi",
            "Yüksek Emicilik",
            "Dermatolojik Test Onaylı",
            "Anatomik Kesim",
            "Koku Kontrolü",
            "Yumuşak Doku",
            "Deneme ve Seyahat İçin İdeal"
        },
        Specifications = new Dictionary<string, string>
        {
            { "Beden", "M (Medium)" },
            { "Paket İçeriği", "12 Adet" },
            { "Özellik", "Islaklık Göstergesi" },
            { "Emicilik Kapasitesi", "Orta-Yüksek (800ml+)" },
            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
            { "Bel Çevresi", "85-115 cm" },
            { "Sertifikalar", "CE, ISO 9001" },
            { "Marka", "MyFix" }
        },
        UsageAreas = new List<string>
        {
            "Evde Bakım",
            "Seyahat",
            "Deneme Kullanımı",
            "Kısa Süreli İhtiyaçlar"
        },
        IsAvailableForExport = true,
        IsPrivateLabelAvailable = true
    }
},
                // MyFix Underpad Ürünleri
                {
                    "myfix-underpad-60x60",
                    new ProductDetailViewModel
                    {
                        Slug = "myfix-underpad-60x60",
                        Name = "MyFix Underpad (Yatak Koruyucu)",
                        Brand = "MyFix",
                        Category = "Medikal",
                        SubCategory = "Underpad (Yatak Koruyucu Örtü)",
                        PackSize = "30'lu Paket",
                        Size = "60 × 60 cm",
                        MainImage = "/Image/3.png",
                        Images = new List<string> { "/Image/3.png" },
                        ShortDescription = "Kompakt boy yatak koruyucu örtü",
                        Description = @"MyFix Underpad 60x60, kompakt boyutuyla pratik kullanım için ideal yatak koruyucu örtüdür. 
                                       Yüksek emicilik kapasitesi ile yatak ve döşemeleri korur.",
                        Features = new List<string>
                        {
                            "Kompakt Boy (60×60)",
                            "Yüksek Emicilik",
                            "Su Geçirmez Alt Tabaka",
                            "Yumuşak Üst Yüzey",
                            "Hızlı Emilim",
                            "Pratik Kullanım",
                            "Hijyenik",
                            "30'lu Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Ebat", "60 × 60 cm" },
                            { "Paket İçeriği", "30 Adet" },
                            { "Emicilik Kapasitesi", "Orta-Yüksek" },
                            { "Malzeme", "Nonwoven, Fluff Pulp, SAP, PE Film" },
                            { "Kullanım", "Tek Kullanımlık" },
                            { "Sertifikalar", "CE, ISO 9001" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Hastaneler",
                            "Evde Bakım",
                            "Klinikler",
                            "Bebek Bakımı"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
                
    "myfix-underpad-60x90",
    new ProductDetailViewModel
    {
        Slug = "myfix-underpad-60x90",
        Name = "Underpad (Yatak Koruyucu)",
        Brand = "MyFix",
        Category = "Medikal",
        SubCategory = "Underpad (Yatak Koruyucu Örtü)",
        PackSize = "30'lu Paket",
        Size = "60 × 90 cm",
        MainImage = "/Image/1.png",
        Images = new List<string> { "/Image/1.png" },
        ShortDescription = "Standart boy yatak koruyucu örtü - Yumuşak yüzey",
        Description = @"MyFix Underpad 60x90, standart boy yatak koruyucu örtüdür. 
                       Yumuşak yüzey yapısı ile konfor sağlarken, yüksek emicilik kapasitesi ile güvenilir koruma sunar.
                       Günlük kullanım için ideal boyut ve performansa sahiptir.",
        Features = new List<string>
        {
            "Standart Boy (60×90 cm)",
            "Yumuşak Yüzey",
            "Yüksek Emicilik",
            "Su Geçirmez Altyapı",
            "Cilt Dostu Üst Yüzey",
            "Hızlı Kuruma",
            "Ekonomik",
            "Hijyenik Kullanım",
            "30'lu Paket"
        },
        Specifications = new Dictionary<string, string>
        {
            { "Ebat", "60 × 90 cm" },
            { "Paket İçeriği", "30 Adet" },
            { "Özellik", "Yumuşak Yüzey" },
            { "Emicilik Kapasitesi", "Yüksek" },
            { "Malzeme", "Nonwoven, Fluff Pulp, SAP, PE Film" },
            { "Kullanım", "Tek Kullanımlık" },
            { "Sertifikalar", "CE, ISO 9001" },
            { "Marka", "MyFix" }
        },
        UsageAreas = new List<string>
        {
            "Hastaneler",
            "Evde Hasta Bakımı",
            "Bakım Evleri",
            "Klinikler",
            "Yaşlı Bakım Merkezleri"
        },
        IsAvailableForExport = true,
        IsPrivateLabelAvailable = true
    }
},
                // Hijyen & Temizlik - Lady Clean Kadın Pedi
                {
                    "lady-clean-pedi",
                    new ProductDetailViewModel
                    {
                        Slug = "lady-clean-pedi",
                        Name = "Lady Clean Kadın Hijyen Pedi",
                        Brand = "Lady Clean",
                        Category = "Hijyen",
                        SubCategory = "Kadın Hijyen Pedi",
                        PackSize = "8'li / 10'lu Paket",
                        Size = "Normal / Long",
                        MainImage = "/Image/26.png",
                        Images = new List<string> { "/Image/26.png" },
                        ShortDescription = "Normal ve Long varyantları ile kadın hijyen pedi",
                        Description = @"Lady Clean Kadın Hijyen Pedi, kadınların günlük hijyen ihtiyaçları için özel olarak tasarlanmıştır. 
                                       Normal ve Long olmak üzere 2 farklı varyant ile farklı ihtiyaçlara cevap verir. 
                                       Dermatolojik olarak test edilmiş, tüm ciltler için uygundur.",
                        Features = new List<string>
                        {
                            "2 Farklı Varyant (Normal & Long)",
                            "8'li ve 10'lu Paket Seçenekleri",
                            "Dermatolojik Test Onaylı",
                            "Yumuşak Üst Yüzey",
                            "Yüksek Emicilik",
                            "Nefes Alabilen Yapı",
                            "Kanat Yapılı",
                            "Tüm Ciltler İçin Uygun"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Varyantlar", "Normal, Long" },
                            { "Paket Seçenekleri", "8'li, 10'lu" },
                            { "Malzeme", "Nonwoven Fabric, SAP, PE Film" },
                            { "Özellik", "Kanatlı Yapı" },
                            { "pH Dengesi", "Cilt Dostu" },
                            { "Sertifikalar", "Dermatolojik Test Onaylı" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Günlük Kullanım",
                            "Kadın Hijyeni",
                            "Tüm Ciltler",
                            "Normal ve Yoğun Akış"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                // CleanPad Mendiller
                {
                    "cleanpad-el-yuz-mendili",
                    new ProductDetailViewModel
                    {
                        Slug = "cleanpad-el-yuz-mendili",
                        Name = "CleanPad El & Yüz Temizleme Mendili",
                        Brand = "CleanPad",
                        Category = "Hijyen",
                        SubCategory = "Islak Mendil",
                        PackSize = "72'li Paket",
                        Size = "",
                        MainImage = "/Image/26.png",
                        Images = new List<string> { "/Image/26.png" },
                        ShortDescription = "Alkol içermeyen, cilde dost el ve yüz mendili",
                        Description = @"CleanPad El & Yüz Temizleme Mendili, günlük hijyen için ideal üründür. 
                                       Alkol içermez, dermatolojik olarak test edilmiştir. pH dengeli formülü ile cildi tahriş etmez.",
                        Features = new List<string>
                        {
                            "Alkol İçermez",
                            "pH Dengeli",
                            "Dermatolojik Test Onaylı",
                            "Yumuşak Doku",
                            "Hoş Koku",
                            "Pratik Ambalaj",
                            "Günlük Kullanım",
                            "72'li Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Paket İçeriği", "72 Adet" },
                            { "Mendil Boyutu", "20 × 20 cm" },
                            { "İçerik", "Su, Gliserin, Aloe Vera" },
                            { "pH Değeri", "5.5 (Cilt Dostu)" },
                            { "Alkol", "İçermez" },
                            { "Sertifikalar", "Dermatolojik Test Onaylı" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Günlük Temizlik",
                            "Seyahat",
                            "Ofis",
                            "Spor Sonrası"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
                    "cleanpad-vucut-temizleme",
                    new ProductDetailViewModel
                    {
                        Slug = "cleanpad-vucut-temizleme",
                        Name = "CleanPad Vücut Temizleme Mendili",
                        Brand = "CleanPad",
                        Category = "Hijyen",
                        SubCategory = "Islak Mendil",
                        PackSize = "48'li Paket",
                        Size = "",
                        MainImage = "/Image/24.png",
                        Images = new List<string> { "/Image/24.png" },
                        ShortDescription = "Tüm ciltler için özel formül vücut temizleme mendili",
                        Description = @"CleanPad Vücut Temizleme Mendili, tüm ciltler için özel olarak formüle edilmiştir. 
                                       Paraben ve alkol içermez. Hasta ve yaşlı bakımında güvenle kullanılabilir.",
                        Features = new List<string>
                        {
                            "Tüm Ciltler İçin",
                            "Paraben İçermez",
                            "Alkol İçermez",
                            "Yumuşak & Dayanıklı Doku",
                            "Büyük Boy Mendil",
                            "Hasta Bakımı İçin İdeal",
                            "Dermatolojik Test Onaylı",
                            "48'li Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Paket İçeriği", "48 Adet" },
                            { "Mendil Boyutu", "30 × 30 cm" },
                            { "İçerik", "Su, Gliserin, Aloe Vera, Chamomile" },
                            { "pH Değeri", "5.5 (Cilt Dostu)" },
                            { "Paraben", "İçermez" },
                            { "Alkol", "İçermez" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Hasta Bakımı",
                            "Yaşlı Bakımı",
                            "Hastaneler",
                            "Evde Bakım"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
                    "cleanpad-yuzey-temizleme",
                    new ProductDetailViewModel
                    {
                        Slug = "cleanpad-yuzey-temizleme",
                        Name = "CleanPad Yüzey Temizleme Mendili",
                        Brand = "CleanPad",
                        Category = "Hijyen",
                        SubCategory = "Temizlik Mendili",
                        PackSize = "100'lü Paket",
                        Size = "",
                        MainImage = "/Image/25.png",
                        Images = new List<string> { "/Image/25.png" },
                        ShortDescription = "Beyaz sirke ve karbonat içeren çok amaçlı yüzey temizleyici",
                        Description = @"CleanPad Yüzey Temizleme Mendili, doğal içerikleri ile tüm yüzeylerde güvenle kullanılabilir. 
                                       Beyaz sirke ve karbonat içeriği sayesinde etkili temizlik sağlar, kimyasal koku bırakmaz.",
                        Features = new List<string>
                        {
                            "Beyaz Sirke & Karbonat",
                            "Doğal İçerikler",
                            "Tüm Yüzeyler İçin",
                            "Kimyasal Koku Yok",
                            "Dayanıklı Doku",
                            "Çok Amaçlı Kullanım",
                            "Ekonomik",
                            "100'lü Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Paket İçeriği", "100 Adet" },
                            { "Mendil Boyutu", "25 × 25 cm" },
                            { "İçerik", "Beyaz Sirke, Sodyum Bikarbonat, Su" },
                            { "Kullanım Alanı", "Tüm Yüzeyler" },
                            { "Koku", "Doğal Ferahlık" },
                            { "Tip", "Çok Amaçlı" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Evler",
                            "Ofisler",
                            "Mutfaklar",
                            "Banyolar",
                            "Camlar",
                            "Mobilyalar"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                // Bebek Ürünleri
                {
                    "myfix-bebek-bakim-ortusu",
                    new ProductDetailViewModel
                    {
                        Slug = "myfix-bebek-bakim-ortusu",
                        Name = "MyFix Bebek Bakım Örtüsü",
                        Brand = "MyFix",
                        Category = "Bebek",
                        SubCategory = "Bebek Bakım Örtüsü",
                        PackSize = "10'lu Paket",
                        Size = "60 × 60 cm",
                        MainImage = "/Image/13.png",
                        Images = new List<string> { "/Image/13.png" },
                        ShortDescription = "Bebeğiniz için cilt dostu, güvenli bakım örtüsü",
                        Description = @"MyFix Bebek Bakım Örtüsü, bebek bakımı sırasında hijyenik bir ortam sağlar. 
                                       Yumuşak dokusu ve yüksek emicilik özelliği ile bebeğinizin konforunu düşünür.",
                        Features = new List<string>
                        {
                            "Cilt Dostu & Güvenli",
                            "Yumuşak Yüzey",
                            "Yüksek Emicilik",
                            "Su Geçirmez Alt Tabaka",
                            "Bebek Bakımı İçin İdeal",
                            "Pratik Kullanım",
                            "Hijyenik",
                            "10'lu Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Ebat", "60 × 60 cm" },
                            { "Paket İçeriği", "10 Adet" },
                            { "Malzeme", "Nonwoven, Fluff Pulp, SAP, PE Film" },
                            { "Kullanım", "Tek Kullanımlık" },
                            { "Güvenlik", "Bebek Cildine Uygun" },
                            { "Sertifikalar", "Dermatolojik Test Onaylı" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Bebek Odası",
                            "Alt Değiştirme",
                            "Seyahat",
                            "Dışarı Çıkış"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                {
                    "myfix-bebek-bezi",
                    new ProductDetailViewModel
                    {
                        Slug = "myfix-bebek-bezi",
                        Name = "MyFix Bebek Bezi",
                        Brand = "MyFix",
                        Category = "Bebek",
                        SubCategory = "Bebek Bezi",
                        PackSize = "Varyant",
                        Size = "Mini, Midi, Maxi, Junior, Junior Plus",
                        MainImage = "/Image/12.png",
                        Images = new List<string> { "/Image/12.png" },
                        ShortDescription = "10 farklı beden ve paket seçeneği ile bebek bezleri",
                        Description = @"MyFix Bebek Bezi, bebeğinizin her dönemine uygun beden seçenekleri sunar. 
                                       Mini'den Junior Plus'a kadar 10 farklı varyant ile bebeğinizin konforunu en üst seviyede tutar. 
                                       Yüksek emicilik, yumuşak yüzey ve nefes alabilen yapısı ile bebeğinizin cildini korur.",
                        Features = new List<string>
                        {
                            "10 Farklı Varyant",
                            "Mini (2-5 kg) - 64 Adet",
                            "Midi (4-9 kg) - 56/64 Adet",
                            "Maxi (7-18 kg) - 40/44/48 Adet",
                            "Junior (11-25 kg) - 40/44 Adet",
                            "Junior Plus (16-30 kg) - 40 Adet",
                            "Yüksek Emicilik",
                            "Yumuşak & Nefes Alabilen",
                            "Elastik Bantlar",
                            "Sızıntı Önleyici",
                            "Dermatolojik Test Onaylı"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Mini (2-5 kg)", "64 Adet" },
                            { "Midi (4-9 kg)", "56 veya 64 Adet" },
                            { "Maxi (7-18 kg)", "40, 44 veya 48 Adet" },
                            { "Junior (11-25 kg)", "40 veya 44 Adet" },
                            { "Junior Plus (16-30 kg)", "40 Adet" },
                            { "Toplam Varyant", "10 Seçenek" },
                            { "Malzeme", "Nonwoven, SAP, PE Film" },
                            { "Sertifikalar", "Dermatolojik Test Onaylı" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Yenidoğan Bakımı",
                            "Bebek Bakımı",
                            "Çocuk Bakımı",
                            "Günlük Kullanım"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                },
                // Pet Ürünleri
                {
                    "cleanpet-pedi-60x90",
                    new ProductDetailViewModel
                    {
                        Slug = "cleanpet-pedi-60x90",
                        Name = "CleanPet Evcil Hayvan Pedi",
                        Brand = "CleanPet",
                        Category = "Pet",
                        SubCategory = "Evcil Hayvan Pedi",
                        PackSize = "30'lu Paket",
                        Size = "60 × 90 cm",
                        MainImage = "/Image/23.png",
                        Images = new List<string> { "/Image/23.png" },
                        ShortDescription = "Lavanta kokulu, evcil hayvanlarınız için hijyenik ped",
                        Description = @"CleanPet Evcil Hayvan Pedi, köpekler için özel olarak tasarlanmış hijyenik kullanım pedidir. 
                                       Lavanta kokusu ile ferah bir ortam sağlar. Yüksek emicilik kapasitesi ve su geçirmez alt tabakası 
                                       sayesinde zemini korur.",
                        Features = new List<string>
                        {
                            "Lavanta Kokulu",
                            "Yüksek Emicilik",
                            "Su Geçirmez Alt Tabaka",
                            "Koku Kontrolü",
                            "Kaymaz Yapı",
                            "Köpekler İçin İdeal",
                            "Hijyenik Kullanım",
                            "30'lu Paket"
                        },
                        Specifications = new Dictionary<string, string>
                        {
                            { "Ebat", "60 × 90 cm" },
                            { "Paket İçeriği", "30 Adet" },
                            { "Koku", "Lavanta" },
                            { "Malzeme", "Nonwoven, Fluff Pulp, SAP, PE Film" },
                            { "Kullanım", "Tek Kullanımlık" },
                            { "Uygunluk", "Tüm Köpek Cinslerine Uygun" }
                        },
                        UsageAreas = new List<string>
                        {
                            "Ev İçi Köpek Tuvalet Eğitimi",
                            "Yaşlı Köpekler",
                            "Hasta Köpekler",
                            "Seyahat",
                            "Geceleri Kullanım"
                        },
                        IsAvailableForExport = true,
                        IsPrivateLabelAvailable = true
                    }
                }
            };

            return products.ContainsKey(slug) ? products[slug] : null;
        }
    }

    // ViewModel
    public class ProductDetailViewModel
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string PackSize { get; set; }
        public string Size { get; set; }
        public string MainImage { get; set; }
        public List<string> Images { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public List<string> Features { get; set; }
        public Dictionary<string, string> Specifications { get; set; }
        public List<string> UsageAreas { get; set; }
        public bool IsAvailableForExport { get; set; }
        public bool IsPrivateLabelAvailable { get; set; }
    }
}