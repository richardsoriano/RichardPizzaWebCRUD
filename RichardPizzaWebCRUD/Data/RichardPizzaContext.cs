using Microsoft.EntityFrameworkCore;
using RichardPizzaWebCRUD.Models;

namespace RichardPizzaWebCRUD.Data
{
    public class RichardPizzaContext : DbContext
    {
        public RichardPizzaContext() { }
        public RichardPizzaContext(DbContextOptions<RichardPizzaContext> options)
            : base(options) { }
        public virtual DbSet<Product> Products { get; set; } = null!;
    }
}
