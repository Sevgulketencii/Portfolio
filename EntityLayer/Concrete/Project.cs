using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime ProjectDate { get; set; }
        public string ProjectImgUrl { get; set; }
        public string ProjectUrl { get; set; }
        public bool ProjectStatus { get; set; }
        public virtual IList<Language> Liste { get; set; }
    }
}
