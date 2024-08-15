using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EducationDB.Entities
{
     public class Lesson
    {
        [Key]
        public int LessonNo {  get; set; }  
        public string Name {  get; set; }   
        public int DepartmentID {  get; set; }  
        public virtual Department Department { get; set; }  
        public virtual ICollection <Student>Students { get; set; }  
        public Lesson()
        {
            Students = new HashSet<Student>();
        }
    }
}
