using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string ImgUrl { get; set; }
        public DateTime BirthDay { get; set; }
        public string ContactTitle { get; set; }
        public string ContactDesciription { get; set; }
        public bool ContactStatus { get; set; }
    }
}
