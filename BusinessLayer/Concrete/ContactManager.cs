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
    public class ContactManager : ContactService
    {
        IContactDal _contact;

        public ContactManager(IContactDal contact)
        {
            _contact = contact;
        }

        public void ekle(Contact eklenen)
        {
            _contact.ekle(eklenen);
        }

        public void güncelle(Contact guncellenen)
        {
            _contact.guncelle(guncellenen);
        }

        public List<Contact> HeaderContact()
        {
            return _contact.HeaderContact();
        }

        public Contact IdGore(int id)
        {
            return _contact.GetId(id);
        }

        public List<Contact> list()
        {
            return _contact.Listele();
        }

        public void sil(Contact silinen)
        {
            _contact.sil(silinen);
        }
    }
}
