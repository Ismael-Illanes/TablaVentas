using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VentasChart.Data;
using VentasChart.Model;

namespace VentasChart.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _context;
        public IEnumerable<Articulos> Articulos { get; set; }

        public IndexModel(ILogger<IndexModel> logger, AppDbContext dbContext)
        { 
            _logger = logger;
            _context = dbContext;
        }


        public void OnGet()
        {
           Articulos =  _context.LineasVentas;
        }
    }
}