using System.ComponentModel.DataAnnotations;

namespace DTO.Requests.Product
{
    public class ProductEditDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Weight { get; set; }
        [Required]
        public int Price { get; set; }
    }
}