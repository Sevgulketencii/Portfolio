﻿using System;
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
        public int AboutId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string ImgUrl { get; set; }
        public int WorkingYear { get; set; }
        public DateTime BirthDay { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDesciription { get; set; }
        public bool AboutStatus { get; set; }
    }
}
