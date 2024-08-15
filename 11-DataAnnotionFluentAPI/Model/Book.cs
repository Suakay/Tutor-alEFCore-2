using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _11_DataAnnotionFluentAPI.Model
{
    public class Book
    {
       public int BookId {  get; set; }
        [Required]
        [MaxLength(100)]
        [Column("Description",Order =2,TypeName ="nvarchar(100)")]
        public string Title {  get; set; }  
        public Author Author { get; set; }
        [ForeignKey("Author")]
        public int AuthorFK {  get; set; }  
    }
}
