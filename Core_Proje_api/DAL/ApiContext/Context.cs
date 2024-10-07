using Core_Proje_api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje_api.DAL.ApiContext
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SALIH\\SQLEXPRESS;database=CoreProjeDB2;integrated security = true;TrustServerCertificate=True;");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
