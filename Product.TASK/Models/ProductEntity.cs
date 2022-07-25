using System.ComponentModel.DataAnnotations;

namespace Product.TASK.Models
{
    public class ProductEntity
    {
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        public float cost { get; set; }
        public float price { get; set; }
    }
}
