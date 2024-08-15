using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_NTierMapping.DATA
{
    public class Film:BaseClass
    {
        public string FilmAdi {  get; set; }
        public DateTime SonyayinTarihi { get; set; }    
        public int IzlemeSayisi {  get; set; }  
        public int KategoriID {  get; set; }    
        public int FilmDetayID {  get; set; }   

        public virtual FilmKategori FilmKategorisi {  get; set; }   
        public virtual FilmDetay FilmDetay { get; set; }
        public virtual List<OyuncuFilm> FilmOyunculari { get; set; }    

    }
}
