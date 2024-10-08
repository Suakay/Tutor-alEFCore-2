﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_UrunEklemeOtomasyonu.Entities
{
    public class BaseEntity
    {
        [Key]
        [Column(Order =1)]
        public int Id { get; set; }
        [Key]
        [Column(Order = 2)]
        public string Name { get; set; }

        public bool IsActive {  get; set; }

        [Column(TypeName ="datetime2")]
        public DateTime AddedDate { get; set; }     


    }
}
