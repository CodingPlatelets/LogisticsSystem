using System.ComponentModel.DataAnnotations;

namespace LogisticsSystem.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
