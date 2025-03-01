﻿using Microsoft.AspNetCore.Identity;

namespace AnketHazırlamaPortalı.Dtos
{
    public class RegisterDto 
    {
        public string ? Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        
        public string Password { get; set; }

        public string PasswordConfirm { get; set; }

    }
}
