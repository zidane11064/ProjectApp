using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using ProjectApp.API.Data;

namespace ProjectApp.API.Models
{
    public class Role : IdentityRole<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}