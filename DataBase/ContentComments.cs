using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase
{
    public class ContentComments
    {
        public int Comment_ID { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public String CommentText { get; set; }
        public DateTime CommentData { get; set; }

        public int User_ID { get; set; }
        public virtual User user { get; set; }

        public int Content_ID { get; set; }
        public virtual PageContent PageContent { get; set; }
    }
}
