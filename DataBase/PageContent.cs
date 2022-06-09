using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class PageContent
    {
        public int Content_ID { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        //[Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        //[Required(ErrorMessage = "Content is required.")]
        public string MainContent { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Image { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime PublicationData { get; set; }

        public bool Active { get; set; }

        public bool AutoActive { get; set; }

        public bool Deleted { get; set; }

        [NotMapped]
        public IFormFile FrontImage { get; set; }

        public virtual IEnumerable<ContentComments> Comments { get; set; }
        public virtual IEnumerable<PostHistory> postHistorys { get; set; }

        public int Page_ID { get; set; }
        public virtual Page Page { get; set; }
    }
}
