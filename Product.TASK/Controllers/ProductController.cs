using Microsoft.AspNetCore.Mvc;
using Product.TASK.Dtos;
using Product.TASK.Services;

namespace Product.TASK.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }
        [HttpGet]
        public IActionResult Get(int Id)
        {
            return Ok(_productService.Get(Id));
        }
        [HttpDelete]
        public IActionResult delete(int Id)
        {
            _productService.Delete(Id);

            return Ok(" Done!!!! ");
        }
        [HttpPost]
        public IActionResult Create([FromBody]CreateDto dto)
        {

            return Ok(_productService.Create(dto));
        }

        [HttpPut]
        public IActionResult Update([FromBody] UpdateDto dto)
        {

            return Ok(_productService.Update(dto));
        }
    }
}

