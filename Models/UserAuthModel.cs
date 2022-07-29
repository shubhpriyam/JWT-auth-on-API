using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication.Models
{
    public class UserAuthModel
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string User { get; set; }

        [Required]
        public string Password { get; set; }
        
        public string Role { get; set; }

        public string Token { get; set; }

    }
}
