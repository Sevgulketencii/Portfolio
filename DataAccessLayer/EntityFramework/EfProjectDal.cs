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
    public class EfProjectDal : GenericRepository<Project>, IProjectDal
    {
        Context baglan = new Context();

        public List<Project> ListOnay()
        {
            return baglan.ProjectDb.Where(x => x.ProjectStatus == true).ToList();
        }
    }
}
