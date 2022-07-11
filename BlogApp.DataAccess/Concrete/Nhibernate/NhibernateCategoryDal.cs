using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Core.DataAccess.NHibernate;
using BlogApp.DataAccess.Abstract;
using BlogApp.Entities.Concrete;

namespace BlogApp.DataAccess.Concrete.Nhibernate
{
   public  class NhibernateCategoryDal:NHibernateEntityRepositortyBase<Category>,ICategoryDal
    {
        public NhibernateCategoryDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {

        }
    }
}
