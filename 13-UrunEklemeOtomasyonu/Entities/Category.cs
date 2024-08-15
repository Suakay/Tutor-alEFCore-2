using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_UrunEklemeOtomasyonu.Entities
{
     public class Category:BaseEntity
    {
        [MaxLength(255)]
        public string Description {  get; set; }    
        public  ICollection<Product> Products { get; set; }


    }
}
