using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EducationDB.Entities
{
     public class Laptop
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int StudentNo {  get; set; } 
        public virtual Student Studet { get; set; }
    }
}
