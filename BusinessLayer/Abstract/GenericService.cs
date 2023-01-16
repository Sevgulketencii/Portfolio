using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface GenericService<Table> where Table:class
    {
        List<Table> list();
        void ekle(Table eklenen);
        void sil(Table silinen);
        void güncelle(Table guncellenen);
        Table IdGore(int id);
    }
}
