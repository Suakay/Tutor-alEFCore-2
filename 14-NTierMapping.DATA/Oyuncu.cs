using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_NTierMapping.DATA
{
     public class Oyuncu:BaseClass
    {
        public string OyuncuAdi {get;set;}
        public DateTime DogumTarihi { get;set;} 
        public string Hayati { get;set;}   
        
        public virtual List<OyuncuFilm>OyuncuFilms { get;set;}  

    }
}
