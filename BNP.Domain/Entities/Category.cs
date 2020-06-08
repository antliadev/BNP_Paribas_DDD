using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BNP.Domain.Entities
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public ICollection<Product> Products { get; set; }
    }

}
