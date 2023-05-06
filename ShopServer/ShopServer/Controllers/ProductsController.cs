using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ShopServer.Data;
using ShopServer.Migrations;
using ShopServer.Models.Domain;
using ShopServer.Models.DTO;

namespace ShopServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopDbContext _context;
        public ProductsController(ShopDbContext _context)
        {
            this._context = _context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _context.Products.ToList();
            var productsDto = new List<ProductDto>();
            foreach(var product in products)
            {
                productsDto.Add(new ProductDto()
                {
                    id = product.id,
                    name = product.name,
                    desc = product.desc,
                    price = product.price,
                    category = product.category,
                    create_at = product.create_at,
                    modified_at = product.modified_at,
                });
            }
            return Ok(productsDto);
        }
        [HttpPost]
        public IActionResult Create([FromBody] AddProductRequestDto addProductRequestDto)
        {
            var productDomainModel = new Product
            {
                name = addProductRequestDto.name,
                category = addProductRequestDto.category,
                desc = addProductRequestDto.desc,
                price = addProductRequestDto.price,
                create_at = addProductRequestDto.create_at,
                modified_at = addProductRequestDto.modified_at
            };
            _context.Products.Add(productDomainModel);
            _context.SaveChanges();

            var productDto = new ProductDto
            {
                name = productDomainModel.name,
                category = productDomainModel.category,
                desc = productDomainModel.desc,
                price = productDomainModel.price,
                create_at = productDomainModel.create_at,
                modified_at = productDomainModel.modified_at
            };
            return Ok();
        }
    }
}
