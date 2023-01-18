using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Admin.Models
{
    public class AboutUpdateModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string ImgUrl { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public int WorkingYear { get; set; }
        public string AboutDesciription { get; set; }
        public string AboutTitle { get; set; }

    }
}
