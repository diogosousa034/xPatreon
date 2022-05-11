using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataBase
{
    public class Patrons
    {
        public int PatronFollow_ID { get; set; }

        public int UserID { get; set; }

        public int Page_ID { get; set; }
        public virtual Page Page { get; set; }

    }
}
