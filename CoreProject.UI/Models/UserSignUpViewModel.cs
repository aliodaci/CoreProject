using System.ComponentModel.DataAnnotations;

namespace CoreProject.UI.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad-Soyad")]
        [Required(ErrorMessage ="Lütfen Ad-Soyad Giriniz")]
        public string nameSurname { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string Password { get; set; }

        [Display(Name = "tekrar Şifre")]
        [Compare("Password", ErrorMessage ="Şifreler Uyuşmuyor!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lütfen Email Adresi Giriniz")]
        public string Mail { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }
    }
}
