using Product.TASK.Data;
using Product.TASK.Dtos;
using Product.TASK.Exceptions;
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
        public int Create (CreateDto dto)
        {
            var nameIsExist = _db.products.Any(x => x.name == dto.name);
            if (nameIsExist)
            {
                throw new DuplicatedProductNameException();
            }
            if (dto.price < dto.cost)
            {
                throw new PriceLessCost();
            }
           
            var product = new ProductEntity();

            product.name= dto.name;
            product.price= dto.price;
            product.cost= dto.cost;
            _db.products.Add(product);
            _db.SaveChanges();
            return product.Id;
        }
        public int  Update(UpdateDto dto)
        {
            var product =_db.products.Find(dto.Id);

            product.name = dto.name;
            product.price = dto.price;
            product.cost = dto.cost;
            _db.products.Update(product);
            _db.SaveChanges();
            return product.Id;
        }



    }

}
