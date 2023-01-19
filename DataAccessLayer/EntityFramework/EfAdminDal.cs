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
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
        Context baglan = new Context();

        public Admin login()
        {
            return baglan.AdminDb.FirstOrDefault();
        }
    }
}
