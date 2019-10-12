using Microsoft.EntityFrameworkCore;

namespace TestApi.Models
{
    public class ItemsContext : DbContext
    {
        public ItemsContext(DbContextOptions<ItemsContext> options) :base (options)
        {

        }

        public DbSet<InventoryItems> InventoryItems {get; set;}
    }
}