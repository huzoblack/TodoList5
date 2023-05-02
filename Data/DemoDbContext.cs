using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using ToDoList.Data.Models;

namespace ToDoList.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options) 
        {

        }
        public DbSet<Listeler> Listelerim { get; set; }
        public DbSet<Yapacaklarim> Yapacaklarim { get; set; }
        public DbSet<Yapiyorum> Yapiyorum { get; set; }
        public DbSet<Yaptim> Yaptim { get; set; }

    }
}
