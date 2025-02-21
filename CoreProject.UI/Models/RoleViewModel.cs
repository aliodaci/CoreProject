using System.ComponentModel.DataAnnotations;

namespace CoreProject.UI.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Lütfen rol adını giriniz.")]
        public string name { get; set; }
    }
}
