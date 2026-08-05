using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using productservice.Data;

namespace productservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class productController : ControllerBase
    {
        private AppDbContext appDbContext;
       public productController(AppDbContext _appDbContext)
       {
          appDbContext = _appDbContext;
       }
       
        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            return Ok(appDbContext.Products.ToList());
        }
    }
}