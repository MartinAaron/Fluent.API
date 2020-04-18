using System;
using System.Collections;
using System.Collections.Generic;

namespace Fluent.Entity.Entity
{
    public class Department
    {
        //Primary Key 主键

        public int DepartmentID { get; set; }

        public String Name { get; set; }

        //定义导航属性，外键，关系映射
        public virtual ICollection<Course> Courses { get; set; }
    }
}
