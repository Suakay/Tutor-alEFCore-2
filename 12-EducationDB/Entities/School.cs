using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EducationDB.Entities
{
     public class School
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Student>Students { get; set; }   
        public School()
        {
            Departments = new HashSet<Department>();
            Students = new HashSet<Student>();
        }
    }
}
