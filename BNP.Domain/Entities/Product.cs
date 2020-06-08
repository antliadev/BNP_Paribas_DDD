using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BNP.Domain.Entities
{
   public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        [ForeignKey("Category")]
        public int IdCategory { get; set; }

        public string  Description { get; set; }
        public bool Active { get; set; }
        public Category Category { get; set; }
    }
}
