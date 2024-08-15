using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_NTierMapping.DATA
{
     public class FilmKategori:BaseClass
    {
        public string KategoriAdi {  get; set; }    
        public virtual List<Film> KategorininFilmleri { get; set; } 
    }
}
