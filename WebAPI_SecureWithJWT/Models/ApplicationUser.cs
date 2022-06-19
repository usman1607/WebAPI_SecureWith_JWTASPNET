using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace WebAPI_SecureWithJWT.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
    }
}
