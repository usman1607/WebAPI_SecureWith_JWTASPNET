using Microsoft.AspNetCore.Identity;

namespace WebAPI_SecureWithJWT.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
