using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace PharmaSuite.Logica.Query
{
    internal class QueryVenta
    {
        public Venta buscarPorID(int id)
        {
            using (DbPharmaSuiteContext dc = new DbPharmaSuiteContext())
            {

                Venta v = new();
                v = dc.Venta.SingleOrDefault(s => s.IdVenta.Equals(id));

                return v;
            }
        }
        public List<VentaDetalle> buscarVentaDetalle(int idVenta)
        {
            using (DbPharmaSuiteContext dc = new DbPharmaSuiteContext())
            {
                return dc.VentaDetalles
                         .Where(c => c.IdVenta == idVenta)
                         .ToList();
            }
        }
    }
}
