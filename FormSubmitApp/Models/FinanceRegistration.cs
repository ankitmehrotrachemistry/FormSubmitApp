using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmitApp.Models
{
    public class FinanceRegistration
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Income must be a positive number.")]
        public decimal Income { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Budget must be a positive number.")]
        public decimal Budget { get; set; }

        [Required]
        public string EmploymentStatus { get; set; }

        [Required]
        public string Currency { get; set; }
    }
}
