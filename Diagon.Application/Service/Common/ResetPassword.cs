﻿using System.ComponentModel.DataAnnotations;

namespace Diagon.Application.Service.Common
{
    public class ResetPassword
    {
        [Required]
        public string Password { get; set; } = null;
        [Compare("Password", ErrorMessage = "Password and Confirm Password do not match")]
        public string ConfirmPassword { get; set; } = null;
        public string Email { get; set; } = null;
        public string Token { get; set; } = null;
    }
}
