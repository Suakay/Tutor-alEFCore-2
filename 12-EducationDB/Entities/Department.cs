using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EducationDB.Entities
{
     public class Department
    {
        public int DepartmantId { get; set; } 
        public string Name { get; set; }    
        public virtual ICollection<School>Schools { get; set; }
        public virtual ICollection<Lesson> Lessons {  get; set; }   
        public Department()
        {
            Schools = new HashSet<School>();
            Lessons = new HashSet<Lesson>();
        }
    }
}
