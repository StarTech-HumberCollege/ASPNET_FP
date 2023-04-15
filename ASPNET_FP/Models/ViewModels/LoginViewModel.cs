using System.ComponentModel.DataAnnotations;

namespace ASPNET_FP.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public long Phone { get; set; }

        public LoginViewModel(Account account)
        {
            this.Email = account.Email;
            this.Password = account.Password;
            this.Phone = account.Phone;
        }
        public LoginViewModel(string email)
        {
            this.Email = email;
        }
        public LoginViewModel() { } 
    }
}
