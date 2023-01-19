using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : AdminService
    {
        EfAdminDal _admin;

        public AdminManager(EfAdminDal admin)
        {
            _admin = admin;
        }

        public void ekle(Admin eklenen)
        {
            throw new NotImplementedException();
        }

        public void güncelle(Admin guncellenen)
        {
            throw new NotImplementedException();
        }

        public Admin IdGore(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> list()
        {
            throw new NotImplementedException();
        }

        public Admin Login()
        {
            return _admin.login();
        }

        public void sil(Admin silinen)
        {
            throw new NotImplementedException();
        }
    }
}
