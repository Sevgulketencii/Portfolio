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
    public class ProjectManager : ProjectService
    {
        IProjectDal _project;
       
        public ProjectManager(IProjectDal veri)
        {
            _project = veri;
        }


        public void ekle(Project eklenen)
        {
            _project.ekle(eklenen);
        }

        public void güncelle(Project guncellenen)
        {
            _project.guncelle(guncellenen);
        }

        public Project IdGore(int id)
        {
            return _project.GetId(id);
        }

        public List<Project> list()
        {
            return _project.Listele();
        }

        public void sil(Project silinen)
        {
            _project.sil(silinen);
        }
    }
}
