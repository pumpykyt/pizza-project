using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCore.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Weight { get; set; }
        [Required]
        public int Price { get; set; }
        public string Photo { get; set; }
        public virtual ICollection<Pizza> Pizzas { get; set; }
    }
}