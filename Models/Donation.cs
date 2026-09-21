using System.ComponentModel.DataAnnotations;

namespace GiftOfTheGivers.Models
{
    public class Donation
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [Range(10, 1000000)]
        [Display(Name = "Donation Amount")]
        public decimal Amount { get; set; }

        [Required]
        [Display(Name = "Donation Type")]
        public string DonationType { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Donation Method")]
        public string PaymentMethod { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public DateTime DateSubmitted { get; set; } = DateTime.Now;
    }
}