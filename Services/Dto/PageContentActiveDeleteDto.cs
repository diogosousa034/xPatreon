using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dto
{
    public class PageContentActiveDeleteDto
    {
        public int Content_ID { get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }

        //public int Page_ID { get; set; }
        //public virtual Page Page { get; set; }
    }
}
