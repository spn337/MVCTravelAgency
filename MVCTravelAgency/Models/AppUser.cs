using Microsoft.AspNetCore.Identity;

namespace MVCTravelAgency.Models
{
    public class AppUser : IdentityUser
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
