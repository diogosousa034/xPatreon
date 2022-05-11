using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dto
{
    public class PatronFollowerDto
    {
        public int PatronFollow_ID { get; set; }

        public int UserID { get; set; }

        public int Page_ID { get; set; }
        public virtual Page Page { get; set; }
    }
}
