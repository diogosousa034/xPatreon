using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase
{
    class Page
    {
        public int Page_ID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string PageName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CreatingWhat { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string IsAreCreating { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string ProfileImage { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string CoverImage { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }

        public int Patrons { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime PageCreationData { get; set; }

        [NotMapped]
        public IFormFile FrontImage { get; set; }

        public virtual IEnumerable<Page> page { get; set; }
    }
}
