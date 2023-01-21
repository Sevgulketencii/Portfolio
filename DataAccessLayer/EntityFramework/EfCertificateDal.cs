using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.GenericRepository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCertificateDal : GenericRepository<Certificate>, ICertificateDal
    {
        Context baglan = new Context();
        public List<Certificate> ListeOnay()
        {
            return baglan.CertificateDb.Where(x => x.CertificateStatus == true).ToList();
        }
    }
}
