using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscountService.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiscountService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiscountController  : ControllerBase
    {
        private readonly DiscountDBContext _context;

        public DiscountController(DiscountDBContext context)
        {
            _context = context;
        }

        [HttpGet("{name}", Name = "GetDiscount")]
        public async Task<IActionResult> GetDiscount(string name, [FromQuery] decimal? price)
        {
            if (price is null)
            {
                return BadRequest(new
                {
                    found = false,
                    message = "Price is required to calculate the discount."
                });
            }
            var discount = await _context.Discounts
                       .FirstOrDefaultAsync(d => d.ProductName.ToLower() == name.ToLower());

            if (discount is null)
            {
                return Ok(new
                {
                    found = false,
                    message = $"No discount info for {name}"
                });
            }

            var finalPrice = price.Value - (price.Value * discount.DiscountPercent / 100);

            return Ok(new
            {
                found = true,
                productName = discount.ProductName,
                originalPrice = price.Value,
                discountPercent = discount.DiscountPercent,
                finalPrice
            });
        }
    }
}