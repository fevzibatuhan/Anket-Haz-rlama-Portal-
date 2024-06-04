using Microsoft.AspNetCore.Identity;

namespace AnketHazırlamaPortalı.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }

    }
}
