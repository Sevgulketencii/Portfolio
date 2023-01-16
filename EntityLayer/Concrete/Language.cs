using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageImgUrl { get; set; }
        public bool LanguageStatus { get; set; }
        public Project Project { get; set; }
    }
}
