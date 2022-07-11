using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Entities.Concrete;

namespace BlogApp.DataAccess.Concrete.EntityFramework
{
    class CategoryMap:EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Categories", @"dbo");
            HasKey(x => x.CategoryId);
            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.CategoryName).HasColumnName("CategoryName");
            Property(x => x.CategoryDescription).HasColumnName("CategoryDescription");
            Property(x => x.Status).HasColumnName("Status");
        }

      
    }
}
