using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.GenericRepository
{
    public class GenericRepository<Table> : IGenericDal<Table> where Table : class
    {
        Context baglan = new Context();
        public void ekle(Table eklenen)
        {
            baglan.Set<Table>().Add(eklenen);
            baglan.SaveChanges();

        }

        public Table GetId(int id)
        {
            return baglan.Set<Table>().Find(id);
        }

        public void guncelle(Table guncellenen)
        {
            baglan.Set<Table>().Update(guncellenen);
            baglan.SaveChanges();
        }

        public List<Table> Listele()
        {
            throw new NotImplementedException();
        }

        public void sil(Table silinen)
        {
            throw new NotImplementedException();
        }
    }
}
