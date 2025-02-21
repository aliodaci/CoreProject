using System.ComponentModel.DataAnnotations;

namespace CoreProject.UI.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="LÜtfen kullanıcı adını giriniz.")]
        public string username { get; set; }
        [Required(ErrorMessage ="Lütfen şifrenizi giriniz.")]
        public string password { get; set; }
    }
}
