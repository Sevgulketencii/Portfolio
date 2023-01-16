using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<Table> where Table:class
    {
        List<Table> Listele();
        void ekle(Table eklenen);
        void sil(Table silinen);
        void guncelle(Table guncellenen);
        Table GetId(int id);
    }
}
