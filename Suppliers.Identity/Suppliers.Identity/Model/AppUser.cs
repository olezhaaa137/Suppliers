﻿using Microsoft.AspNetCore.Identity;

namespace Suppliers.Identity.Model
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public string? Organization { get; set; }
    }
}
