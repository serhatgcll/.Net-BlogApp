using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Entities.Concrete;
using FluentNHibernate.Mapping;

namespace BlogApp.DataAccess.Concrete.Nhibernate.Mappings
{
    public class CategoryMap:ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");
            LazyLoad();
            Id(x => x.CategoryId).Column("CategoryId");
            Map(x => x.CategoryId).Column("CategporyId");
            Map(x => x.CategoryName).Column("CategoryName");
            Map(x => x.CategoryDescription).Column("CategoryDescription");
            Map(x => x.CategoryStatus).Column("CategoryStatus");
        }
    }
}
