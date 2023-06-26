using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopServer.Data;
using ShopServer.Models.Domain;
using ShopServer.Models.DTO;
using System.Collections.Immutable;

namespace ShopServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private ShopDbContext _context;
        public DiscountController(ShopDbContext _context)
        {
            this._context = _context;
        }
        [HttpGet]
        public IActionResult GetAllDiscounts()
        {
            var discounts = _context.Discounts.ToList();
            var discountsDto = new List<DiscountDto>();
            foreach(var discount in discounts)
            {
                discountsDto.Add(new DiscountDto()
                {
                    id = discount.id,
                    name = discount.name,
                    discount_percent = discount.discount_percent,
                    modified_at = discount.modified_at,
                    created_at = discount.created_at
                });
            }
            return Ok(discountsDto);
        }
        [HttpPost]
        public IActionResult AddDiscount([FromBody] AddDiscountRequestDto discountDto)
        {
            var discount = new Discount()
            {
                name = discountDto.name,
                discount_percent = discountDto.discount_percent,
                modified_at = discountDto.modified_at,
                created_at = discountDto.created_at
            };
            this._context.Discounts.Add(discount);
            this._context.SaveChanges();
            return Ok();
        }
    }
}
