using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Entity.Entity
{
  public  class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime? CreateTime { get; set; }
        public double Double { get; set; }
        public string Address{get;set;}
    }
}
