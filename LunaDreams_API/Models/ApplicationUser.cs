using Microsoft.AspNetCore.Identity;
namespace LunaDreams_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
