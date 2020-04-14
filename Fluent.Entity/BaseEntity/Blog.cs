using System;
using System.Collections.Generic;
using System.Text;

namespace Fluent.Entity.BaseEntity
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime? CreateTime { get; set; }
        public double Double { get; set; }
        public float Float { get; set; }
    }
}
