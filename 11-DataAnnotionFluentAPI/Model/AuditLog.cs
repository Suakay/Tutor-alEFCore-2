using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DataAnnotionFluentAPI.Model
{
    [NotMapped]
    public  class AuditLog
    {
        public int EntityId {  get; set; }  
        public int UserId {  get; set; }    
        public DateTime Modified {  get; set; } 

    }
}
