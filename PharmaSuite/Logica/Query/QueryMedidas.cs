using Microsoft.IdentityModel.Tokens;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaSuite.Logica.Query
{
    internal class QueryMedidas
    {
        public List<Medida> listaMedidas()
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            if (dc.Medida.IsNullOrEmpty())
            {
                return new List<Medida>();
            }
            else
            {
                return new List<Medida>(dc.Medida);
            }

        }
    }
}
