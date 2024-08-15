using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _10_RelatinshpEFCore.Entities
{
    public class Product
    {
        public Product()
        {
            Date= DateTime.Now;
        }
        public int ProductId { get; set; }  
        public string Name {  get; set; }   
        public int Stock {  get; set; } 
        public double Price {get; set; }
        public int CategoryRefId {  get; set; } 
        public DateTime Date { get; set; }

        public CategoryAttribute Category { get; set; }
        public Category category { get; set; }      

    }
}
