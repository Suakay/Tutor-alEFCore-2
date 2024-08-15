using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_NTierMapping.DATA
{
     public class FilmDetay:BaseClass
    {
        public string FilmDetayı {  get; set; } 
        public int FilmID {  get; set; }    
        public virtual Film DetayinFilmi {  get; set; } 

    }
}
