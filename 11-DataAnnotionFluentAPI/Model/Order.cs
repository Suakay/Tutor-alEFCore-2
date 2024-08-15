using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DataAnnotionFluentAPI.Model
{
     public  class Order
    {
        [Key]
        public int OrderNumber {  get; set; }   
        public DateTime CreatedDate { get; set; }   
        public Customer Customer { get; set; }  


    }
}
