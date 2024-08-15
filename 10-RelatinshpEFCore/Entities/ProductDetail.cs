using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_RelatinshpEFCore.Entities
{
    public class ProductDetail
    {
        public int ProductId { get; set; }  
        public string Colour {  get; set; }   
        public int Height {  get; set; }    
        public int Width { get; set; }
        public Product Product { get; set; }    

    }
}
