﻿using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class UserContent
    {
        public int Content_ID { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        [Required(ErrorMessage = "Content is required.")]
        public string MainContent { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Image { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime PublicationData { get; set; }

        [NotMapped]
        public IFormFile FrontImage { get; set; }

        public int User_ID { get; set; }
        public virtual User User { get; set; }
    }
}
