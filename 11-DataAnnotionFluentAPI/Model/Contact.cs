using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DataAnnotionFluentAPI.Model
{
    public class Contact
    {
        public int Id { get; set; } 
        public string FirstName {  get; set; }  
        public string LastName { get; set; }
        [NotMapped] 
        public string FullName =>$"{FirstName} {LastName}";
        public string Email {  get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastAccesed {  get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created {  get; set; }  
        public  AuditLog  AuditLog { get; set; } 

    }
}
