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
       public List<Category> GetList(Expression<Func<Category, bool>> filter = null)
       {

           throw new NotImplementedException();
        }

       public Category Get(Expression<Func<Category, bool>> filter)
       {
           throw new NotImplementedException();
       }

       public Category Add(Category entity)
       {
           throw new NotImplementedException();
       }

       public Category Update(Category entity)
       {
           throw new NotImplementedException();
       }

       public void Delete(Category entity)
       {
           throw new NotImplementedException();
       }
   }
}
