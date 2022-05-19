using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dto
{
    public class PageDto
    {
        public int Page_ID { get; set; }
        public string PageName { get; set; }
        public string CreatingWhat { get; set; }
        public string IsAreCreating { get; set; }
        public string ProfileImage { get; set; }
        public string CoverImage { get; set; }
        public string AboutPage { get; set; }
        public DateTime PageCreationData { get; set; }

        public List<CreateContentDto> posts;

        public virtual IEnumerable<PageContent> Contents { get; set; }
        public virtual IEnumerable<Patrons> patrons { get; set; }

        public int User_ID { get; set; }
        public virtual User User { get; set; }
    }
}
