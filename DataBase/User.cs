using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class User
    {
        public int User_ID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        //[Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        //[Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Image { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        //[Required(ErrorMessage = "Password is required.")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        //[Required(ErrorMessage = "ConfirmPassword is required.")]
        //[DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "Password and confirm password must be equals.")]
        public string ConfirmPassword { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        //[Required(ErrorMessage = "Role is required.")]
        public string Role { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime RegistrationData { get; set; }

        [NotMapped]
        public IFormFile FrontImage { get; set; }
        
        public virtual Page Page { get; set; }
    }
}
