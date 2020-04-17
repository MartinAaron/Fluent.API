using Fluent.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.DataRepository
{
    public class EfDbContext : DbContext
    {
        public EfDbContext():base("name=sqlServer")
        {

        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
