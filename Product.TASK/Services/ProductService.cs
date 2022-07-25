using Product.TASK.Data;
using Product.TASK.Models;
using System.Collections.Generic;
using System.Linq;

namespace Product.TASK.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _db;
        public ProductService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<ProductEntity> GetAll()
        {
            var product = _db.products.ToList();
            return product;
        }

        public ProductEntity Get(int Id)
        {
            var product = _db.products.Find(Id);
            return product;
        }

        public void Delete(int Id)
        {
            var product = _db.products.Find(Id);
            _db.products.Remove(product);
            _db.SaveChanges();
        }

    }
}
