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
    public class EfLanguageDal : GenericRepository<Language>, ILanguageDal
    {
        Context baglan = new Context();
       
        public List<Language> ListOnay()
        {
            return baglan.LanguageDb.Where(x => x.LanguageStatus == true).ToList();
        }
    }
}
