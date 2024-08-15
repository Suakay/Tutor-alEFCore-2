using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_NTierMapping.DATA
{
     public class OyuncuFilm:BaseClass
    {
        public int OyuncuID {  get; set; }  
        public int FilmID {  get; set; }    
        public int CalismaGunu {  get; set; }   
        //Navigation prop
        public virtual Film OyuncuFilmi { get; set; }   
        public virtual Oyuncu FilminOyuncusu { get; set; }  

    }
}
