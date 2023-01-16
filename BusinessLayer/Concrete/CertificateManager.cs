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
    public class CertificateManager : CertificateService
    {
        ICertificateDal _certificate;

        public CertificateManager(ICertificateDal certificate)
        {
            _certificate = certificate;
        }

        public void ekle(Certificate eklenen)
        {
            _certificate.ekle(eklenen);
        }

        public void güncelle(Certificate guncellenen)
        {
            _certificate.guncelle(guncellenen);
        }

        public Certificate IdGore(int id)
        {
            return _certificate.GetId(id);
        }

        public List<Certificate> list()
        {
            return _certificate.Listele();
        }

        public void sil(Certificate silinen)
        {
            _certificate.sil(silinen);
        }
    }
}
