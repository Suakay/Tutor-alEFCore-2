using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EducationDB.Entities
{
     public class Student
    {
        [Key]
        public int StudentNo {get; set;}
        public string Name { get; set;} 
        public int Age { get; set;} 
        //Navigation
        public int? SchoolNo { get; set;}
        public virtual School School { get; set;}   
        public virtual Laptop Laptop { get; set;}   
        public virtual StudentDetail StudenDetail { get; set;}   
        public virtual ICollection<Lesson> Lessons { get; set;}
        public Student()
        {
            Lessons = new List<Lesson>();
        }
    }
}
