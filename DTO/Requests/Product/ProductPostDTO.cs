using System.ComponentModel.DataAnnotations;

namespace DTO.Requests.Product
{
    public class ProductPostDTO
    {
        [Required]
        public string Name { get; set; }
        public int Weight { get; set; }
        [Required]
        public int Price { get; set; }
    }
}