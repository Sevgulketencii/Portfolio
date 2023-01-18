using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolyo.Areas.Admin.Models
{
    public class CertificateUpdateModel
    {
        public int CertificateId { get; set; }
        public String CertificateName { get; set; }
        public String Company { get; set; }
        public String CertificateUrl { get; set; }
        public String CertificateImgUrl { get; set; }
    }
}
