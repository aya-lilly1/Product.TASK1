using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Product.TASK.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int IdEmployee { get; set; }
        public Employee Employee;

        public  List<ProductEntity> ProductEntity { get; set; }
    }
}
