using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.DTOs
{
    public class RegisterDTOs
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "Password must not have longer than 50 characters.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [StringLength(50, ErrorMessage = "Password must not have longer than 50 characters.")]
        public string ConfirmPassword { get; set; }
    }
}
