using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.GenericRepository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        Context baglan = new Context();

        public List<Contact> HeaderContact(Expression<Func<Contact, bool>> filtre)
        {
            return baglan.ContactDb.Where(filtre).Take(4).ToList();
        }
    }
}
