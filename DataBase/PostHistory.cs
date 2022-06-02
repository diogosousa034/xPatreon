using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase
{
    public class PostHistory
    {
        public int PostHistory_ID { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string MainContent { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Image { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime PublicationData { get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }

        public int page_id { get; set; }
        public int PageContent_ID { get; set; }
        public virtual PageContent pagecontent { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateOfChange { get; set; }
    }
}
