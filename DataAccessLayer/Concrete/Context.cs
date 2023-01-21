using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        public DbSet<Certificate> CertificateDb{ get; set; }
        public DbSet<Admin> AdminDb{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("server=77.245.159.27\\MSSQLSERVER2019;database=PortfolyoDb;user=adminsevgul;password=Nisanur55.");
            optionsBuilder.UseSqlServer("server=DESKTOP-KCH0A99;database=PortfolyoDb;integrated security=true");
        }
    }
}
