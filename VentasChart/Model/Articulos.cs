using System.ComponentModel.DataAnnotations;

namespace VentasChart.Model
{
    public class Articulos
    {
        [Key]
        public string Documento { get; set; }
        public int Linea { get; set; }
        public string codigoarticulo { get; set; }
        public string DESCRIPCION { get; set; }
        public string CodigoFamilia { get; set; }
        public double Cantidad { get; set; }
        public double Numerico { get; set; }
        public string Operador { get; set; }
        public double PUnitario { get; set; }
        public char TipoArticulo { get; set; }
        public double IvaArticulo { get; set; }
        public string Caja { get; set; }
        public int Z { get; set; }
        public double RecargoImporte { get; set; }
        public double Recargo { get; set; }
        public string? Observaciones { get; set; }
    }       
}
