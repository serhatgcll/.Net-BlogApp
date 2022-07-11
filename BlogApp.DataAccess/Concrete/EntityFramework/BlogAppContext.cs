using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.DataAccess.Concrete.EntityFramework.Mappings;
using BlogApp.Entities.Concrete;

namespace BlogApp.DataAccess.Concrete.EntityFramework
{
    public class BlogAppContext:DbContext
    {
        public BlogAppContext()
        {
            Database.SetInitializer<BlogAppContext>(null);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Writer>Writers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new WriterMap());

        }

    }
}
