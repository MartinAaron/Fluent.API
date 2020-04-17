using Fluent.DataRepository;
using Fluent.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.API
{ 
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var efDbContext = new EfDbContext())
                {
                    efDbContext.Blogs.Add(new Blog()
                    {
                        Name = "FuSh1",
                        Url = "https://www.aipet.top"
                    });
                    efDbContext.SaveChanges();
                }
            }
            catch (Exception ee)
            {
                throw;
            }
            
        }
    }
}
