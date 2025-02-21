using Microsoft.AspNetCore.Http;

namespace CoreProject.UI.Areas.Admin.Models
{
    public class WriterClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public IFormFile ImageUrl { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
    }
}
