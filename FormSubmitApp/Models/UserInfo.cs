using System.ComponentModel.DataAnnotations;

namespace FormSubmitApp.Models
{
    public class UserInfo
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(500)]
        public string Message { get; set; }
    }
}
