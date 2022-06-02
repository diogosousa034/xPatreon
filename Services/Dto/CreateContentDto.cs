using DataBase;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Services.Dto
{
    public class CreateContentDto
    {
        public int Content_ID { get; set; }
        public string Title { get; set; }
        public string MainContent { get; set; }
        public string Image { get; set; }
        public bool? Active { get; set; }
        public DateTime PublicationData { get; set; }

        [NotMapped]
        public IFormFile FrontImage { get; set; }

        public int Page_ID { get; set; }
        public virtual Page Page { get; set; }
    }
}
