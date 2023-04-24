using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using VentasChart.Data;
using VentasChart.Model;

namespace VentasChart.Pages
{
    public class chartsModel : PageModel
    {
        private readonly AppDbContext _context;
        public IEnumerable<Articulos> Articulos { get; set; }

        public int NumeroFamilias { get; set; }

        public string DatosPorFamilia { get; set; }
        public chartsModel(AppDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            var conn = _context.Database.GetDbConnection();
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(DISTINCT CodigoFamilia) FROM LineasVentas";
            NumeroFamilias = (int)cmd.ExecuteScalar();
            conn.Close();
            Articulos = _context.LineasVentas;
            DatosPorFamilia = string.Join(",", Articulos.GroupBy(lv => lv.CodigoFamilia).Select(g => g.Count()));

        }
    }
}
