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
    public class LanguageManager : LanguageService
    {
        ILanguageDal _language;

        public LanguageManager(ILanguageDal language)
        {
            _language = language;
        }

        public void ekle(Language eklenen)
        {
            _language.ekle(eklenen);
        }

        public void güncelle(Language guncellenen)
        {
            _language.guncelle(guncellenen);
        }

        public Language IdGore(int id)
        {
            return _language.GetId(id);
        }

        public List<Language> list()
        {
            return _language.Listele();
        }

        public void sil(Language silinen)
        {
            _language.sil(silinen);
        }
    }
}
