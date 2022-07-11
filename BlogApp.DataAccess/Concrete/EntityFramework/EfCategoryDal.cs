using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Core.DataAccess.EntityFramework;
using BlogApp.DataAccess.Abstract;
using BlogApp.Entities.Concrete;

namespace BlogApp.DataAccess.Concrete.EntityFramework
{
   public  class EfCategoryDal:EfEntityRepositoryBase<Category,BlogAppContext>,ICategoryDal
   {
   
     
   }
}
