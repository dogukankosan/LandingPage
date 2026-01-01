using System.ComponentModel.DataAnnotations;

namespace MarmaraHijyen.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "Ad Soyad alanı zorunludur.")]
        [StringLength(100, ErrorMessage = "Ad Soyad en fazla 100 karakter olabilir.")]
        [Display(Name = "Ad Soyad")]
        public string FullName { get; set; } = string.Empty;

        [Display(Name = "Firma Adı")]
        [StringLength(200, ErrorMessage = "Firma adı en fazla 200 karakter olabilir.")]
        public string? Company { get; set; }

        [Required(ErrorMessage = "E-posta alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        [Display(Name = "E-posta")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Telefon alanı zorunludur.")]
        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        [Display(Name = "Telefon")]
        public string Phone { get; set; } = string.Empty;

        [Display(Name = "Ülke")]
        [StringLength(100, ErrorMessage = "Ülke adı en fazla 100 karakter olabilir.")]
        public string? Country { get; set; }

        [Required(ErrorMessage = "Konu alanı zorunludur.")]
        [Display(Name = "Konu")]
        public string Subject { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mesaj alanı zorunludur.")]
        [StringLength(5000, MinimumLength = 10, ErrorMessage = "Mesaj en az 10, en fazla 5000 karakter olabilir.")]
        [Display(Name = "Mesaj")]
        public string Message { get; set; } = string.Empty;
    }
}