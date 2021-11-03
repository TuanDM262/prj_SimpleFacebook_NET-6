using System.ComponentModel.DataAnnotations;
using splFacebookShare.Users;
namespace splFacebookNet6.Models.Account
{
    public class EditUser
    {
       
        public string FirstName { get; set; }

      
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [MinLength(6, ErrorMessage = "The Password field must be a minimum of 6 characters")]
        public string Password { get; set; }

        public EditUser() { }

        public EditUser(User user)
        {
            Username = user.UserName;
        }
    }
}