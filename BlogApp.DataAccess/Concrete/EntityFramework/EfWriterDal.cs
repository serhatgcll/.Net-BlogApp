using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Core.DataAccess.EntityFramework;
using BlogApp.DataAccess.Abstract;
using BlogApp.DataAccess.Concrete.EntityFramework;
using BlogApp.Entities.Concrete;

namespace BlogApp.DataAccess.Concrete
{
    public class EfWriterDal:EfEntityRepositoryBase<Writer,BlogAppContext>,IWriterDal
    {
    }
}
