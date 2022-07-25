using Product.TASK.Models;
using System.Collections.Generic;

namespace Product.TASK.Services
{
    public interface IProductService
    {
        void Delete(int Id);
        ProductEntity Get(int Id);
        List<ProductEntity> GetAll();
    }
}