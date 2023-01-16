using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : AboutService
    {
        IAboutDal _about;
        public AboutManager(IAboutDal veri)
        {
            _about = veri;
        }

        public void ekle(About eklenen)
        {
            _about.ekle(eklenen);
        }

        public void güncelle(About guncellenen)
        {
            _about.guncelle(guncellenen);
        }

        public About IdGore(int id)
        {
           return _about.GetId(id);
        }

        public List<About> list()
        {
            return _about.Listele();
        }

        public void sil(About silinen)
        {
            _about.sil(silinen);
        }
    }
}
