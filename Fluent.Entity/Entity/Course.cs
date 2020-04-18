using System;
namespace Fluent.Entity.Entity
{
    public class Course
    {
        //primary Key
        public int CourseID { get; set; }

        public String Title { get; set; }

        //外键
        public int DepartmentID { get; set; }

        //导航属性
        public virtual Department Department { get; set; }

    }
}
