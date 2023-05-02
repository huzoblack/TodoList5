using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using ToDoList.Data;
using ToDoList.Data.Models;

namespace ToDoList.Services
{
    public class ListelerService
    {
        private readonly IDbContextFactory<DemoDbContext> _dbContextFactory;

        public ListelerService(IDbContextFactory<DemoDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void EkleYapacaklarim(Yapacaklarim liste)
        {
            using var context = _dbContextFactory.CreateDbContext();

            context.Yapacaklarim.Add(liste);
            context.SaveChanges();
        }

        public List<Yapacaklarim> YapacaklarimCagir()
        {
            using var context = _dbContextFactory.CreateDbContext();

            return context.Yapacaklarim.ToList();
        }

        public void YapacaklarimSil(int Id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var liste = context.Yapacaklarim.FirstOrDefault(e => e.Id == Id);
            if (liste != null)
            {
                context.Yapacaklarim.Remove(liste);
                context.SaveChanges();
            }
        }

        public void EkleYapiyorum(Yapiyorum liste)
        {
            using var context = _dbContextFactory.CreateDbContext();

            context.Yapiyorum.Add(liste);
            context.SaveChanges();
        }

        public List<Yapiyorum> YapiyorumCagir()
        {
            using var context = _dbContextFactory.CreateDbContext();

            return context.Yapiyorum.ToList();
        }

        public void YapiyorumSil(int Id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var liste = context.Yapiyorum.FirstOrDefault(e => e.Id == Id);
            if (liste != null)
            {
                context.Yapiyorum.Remove(liste);
                context.SaveChanges();
            }
        }

        public void EkleYaptim(Yaptim liste)
        {
            using var context = _dbContextFactory.CreateDbContext();

            context.Yaptim.Add(liste);
            context.SaveChanges();
        }

        public List<Yaptim> YaptimCagir()
        {
            using var context = _dbContextFactory.CreateDbContext();
            
            return context.Yaptim.ToList();
        }

        public void YaptimSil(int Id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var liste = context.Yaptim.FirstOrDefault(e => e.Id == Id);
            if (liste != null)
            {
                context.Yaptim.Remove(liste);
                context.SaveChanges();
            }
        }
        public void YapacaklarimEdit(string name, int Id)
        {

            using var context = _dbContextFactory.CreateDbContext();
            var liste = context.Yapacaklarim.FirstOrDefault(e => e.Id == Id);
            
            liste.Name=name;
            context.Yapacaklarim.Update(liste);
            context.SaveChanges();
        }

        public void YapiyorumEdit(string name, int Id)
        {

            using var context = _dbContextFactory.CreateDbContext();
            var liste = context.Yapiyorum.FirstOrDefault(e => e.Id == Id);

            liste.Name = name;
            context.Yapiyorum.Update(liste);
            context.SaveChanges();
        }

        public void YaptimEdit(string name, int Id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var liste = context.Yaptim.FirstOrDefault(e => e.Id == Id);

            liste.Name = name;
            context.Yaptim.Update(liste);
            context.SaveChanges();
        }
    }
}
