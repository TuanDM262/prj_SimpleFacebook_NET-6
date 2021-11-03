using Microsoft.AspNetCore.Identity;

namespace splFacebookShare.Users
{
   public class User: IdentityUser<string>
    {
        public string? Token { get; set; }
        public bool IsDeleting { get; set; }
    }
}
