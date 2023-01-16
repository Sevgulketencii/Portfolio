using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<About> AboutDb{ get; set; }
        public DbSet<Contact> ContactDb{ get; set; }
        public DbSet<Language> LanguageDb{ get; set; }
        public DbSet<Project> ProjectDb{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KCH0A99;database=Portfolyo;integrated security=true");
        }
    }
}
