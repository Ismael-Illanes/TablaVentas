using VentasChart.Model;
using Microsoft.EntityFrameworkCore;


namespace VentasChart.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Articulos> LineasVentas { get; set; }
    }
}
