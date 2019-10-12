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
    public class productController : ControllerBase
    {
        private readonly ItemsContext _context;

        public productController(ItemsContext context) => _context = context;

        // GET api/inventory item/id
        [HttpGet("{id}")]
        public ActionResult<InventoryItems> GetInventoryItem(int id)
        {
            var InventoryItem = _context.InventoryItems.Find(id);
            if (InventoryItem == null)
            {
                return NotFound();
            }
            
            return InventoryItem;
        }

        // POST api/inventory item
        [HttpPost]
        public ActionResult<InventoryItems> PostInventoryItem([FromForm]InventoryItems inventoryItem)
        {
            _context.InventoryItems.Add(inventoryItem);
            _context.SaveChanges();

            return Ok();
        }

        // PUT api/inventory item/id
        [HttpPut("{id}")]
        public ActionResult PutItemUpdate(int id,[FromForm]InventoryItems inventoryItems)
        {
            var inventory = _context.InventoryItems.Find(id);
            if (inventory == null)
            {
                return NotFound();
            }

            if (inventoryItems.Name != null && inventoryItems.Name != inventory.Name)
            {
                inventory.Name = inventoryItems.Name;
            }
            
            if (inventoryItems.Price != null && inventoryItems.Price != inventory.Price)
            {
                inventory.Price = inventoryItems.Price;
            }

            _context.Entry(inventory).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }

        // DELETE api/inventory item/id
        [HttpDelete("{id}")]
        public ActionResult<InventoryItems> DeleteInventoryItem(int id)
        {
            var inventoryItem = _context.InventoryItems.Find(id);
            if (inventoryItem == null)
            {
                return NotFound();
            }

            _context.InventoryItems.Remove(inventoryItem);
            _context.SaveChanges();

            return inventoryItem;
        }
    }
}