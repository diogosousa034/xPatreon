using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase
{
    public class Page
    {
        public int Page_ID { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string PageName { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string CreatingWhat { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string IsAreCreating { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string ProfileImage { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string CoverImage { get; set; }

        public bool active { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string AboutPage { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime PageCreationData { get; set; }

        [NotMapped]
        public IFormFile FrontImageProfile { get; set; }

        [NotMapped]
        public IFormFile FrontImageCover { get; set; }

        public virtual IEnumerable<PageContent> Contents { get; set; }
        public virtual IEnumerable<Patrons> patrons { get; set; }

        public int User_ID { get; set; }
        public virtual User User { get; set; }
    }
}
