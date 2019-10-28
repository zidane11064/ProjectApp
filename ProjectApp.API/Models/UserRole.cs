using Microsoft.AspNetCore.Identity;
using ProjectApp.API.Models;

namespace ProjectApp.API.Data
{
    public class UserRole : IdentityUserRole<int>
    {
        public User User { get; set; }
        public Role Role { get; set; }
    }
}