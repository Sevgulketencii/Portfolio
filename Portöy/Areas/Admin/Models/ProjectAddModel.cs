using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Admin.Models
{
    public class ProjectAddModel
    {
        public string ProjectName { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectDesciription { get; set; }
        public DateTime Date { get; set; }
        public string ProjectImgUrl { get; set; }
        public string ProjectUrl { get; set; }

    }
}
