using System.ComponentModel.DataAnnotations;

namespace Product.TASK.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public float Salary { get; set; }

     

    }
}
