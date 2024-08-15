using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EducationDB.Entities
{
     public class StudentDetail
    {
        public int Id { get; set; } 
        public string Detail {  get; set; } 
        public int StudentNo {  get; set; } 
        public virtual Student Student { get; set; }
    }
}
