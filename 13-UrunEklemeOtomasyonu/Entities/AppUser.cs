using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_UrunEklemeOtomasyonu.Entities
{
    public class AppUser : BaseEntity
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName=>$"{Name} {LastName}";
        public  bool Gender { get; set; }   
        public DateTime ? BirthDate { get; set; }

    }
}
