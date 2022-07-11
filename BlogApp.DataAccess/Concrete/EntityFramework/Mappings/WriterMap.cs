using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Entities.Concrete;

namespace BlogApp.DataAccess.Concrete.EntityFramework.Mappings
{
    public class WriterMap  :EntityTypeConfiguration<Writer>
    {
        public WriterMap()
        {
            ToTable("Writers", "dbo");
            HasKey(x => x.WriterId);
            Property(x => x.WriterId).HasColumnName("WriterId");
            Property(x => x.WriterName).HasColumnName("WriterName");
            Property(x => x.WriterAbout).HasColumnName("WriterAbout");
            Property(x => x.WriterImage).HasColumnName("WriterImage");
            Property(x => x.WriterMail).HasColumnName("WriterMail");
            Property(x => x.Status).HasColumnName("Status");
        }
    }
}
