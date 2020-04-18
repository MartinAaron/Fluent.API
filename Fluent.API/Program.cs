using Fluent.DataRepository;
using Fluent.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                    //efDbContext.Blogs.Add(new Blog()
                    //{
                    //    Name = "FuSh11",
                    //    Url = "https://www.aipet.top"
                    //});
                    //监测到模型发生改变，将更新模型
                    //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EfDbContext>());

                    //Course _course = new Course() { Title = "你好" };
                    //Course __course = new Course() { Title = "世界" };
                    //List<Course> courses = new List<Course>();
                    //courses.Add(_course);
                    //courses.Add(__course);
                    //efDbContext.Departments.Add(new Department()
                    //{
                    //    Name = "职能机构",
                    //    Courses = courses
                    //});

                    efDbContext.Courses.Add(new Course() {
                        Title="语文"
                    });
                    efDbContext.SaveChanges();
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message); ;
            }

        }
    }
}
