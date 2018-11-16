using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SjeApi.Interfaces.DataAccess;
using SjeApi.DataAccess;
namespace SjeApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public ActionResult GetAllProducts()
        {
            var conn = new ProductsDbContext();
            var productsList = conn.GetProducts();
            
            return Ok(productsList);
        }
    }
}