using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Core.DataAccess;
using BlogApp.Entities.Concrete;

namespace BlogApp.DataAccess.Abstract
{
    public interface IWriterDal : IEntityRepository<Writer>
    {

    }
}
