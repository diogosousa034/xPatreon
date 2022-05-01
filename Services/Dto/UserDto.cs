using DataBase;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Services.Dto
{
    public class UserDto
    {
        public int User_ID { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Image { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Role { get; set; }

        public DateTime RegistrationData { get; set; }

        [NotMapped]
        public IFormFile FrontImage { get; set; }

        public virtual IEnumerable<PageContent> Contents { get; set; }
    }
}
