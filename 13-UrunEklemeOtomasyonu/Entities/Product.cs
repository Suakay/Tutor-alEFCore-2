using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_UrunEklemeOtomasyonu.Entities
{
     public class Product:BaseEntity
    {
        public decimal ? UnitPrice { get; set; }   
        public short? Stock { get; set; }

        [ForeignKey("Category")]
        public int CategoryId {get; set; }
        public Category Category { get; set; }

    }
}
