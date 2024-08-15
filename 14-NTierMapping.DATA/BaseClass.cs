using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_NTierMapping.DATA
{
     public class BaseClass
    {
        public int ID { get; set; } 
        public bool IsActive {  get; set; } 
        public DateTime AddedDate { get; set; } 
        public DateTime ModifiedDate { get; set; }  

    }
}
