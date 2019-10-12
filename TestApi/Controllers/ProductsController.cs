using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestApi.Models;

namespace TestApi.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class productsController : ControllerBase
    {
        private readonly ItemsContext _context;

        public productsController(ItemsContext context) => _context = context;

        // GET api/Product items
        [HttpGet]
        public ActionResult<IEnumerable<InventoryItems>> GetInventory()
        {
            return _context.InventoryItems;
        }

    }
}