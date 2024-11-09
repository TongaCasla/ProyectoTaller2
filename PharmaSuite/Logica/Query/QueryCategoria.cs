using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PharmaSuite.Logica.Query
{
    internal class QueryCategoria
    {
        public List<Categoria> listaCategoria()
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            if (dc.Categorias.IsNullOrEmpty())
            {
                return new List<Categoria>();
            }
            else
            {
                return new List<Categoria>(dc.Categorias);
            }

        }

        public Categoria buscarPorID(int id)
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            Categoria c = new();
            c = dc.Categorias.SingleOrDefault(s => s.IdCategoria.Equals(id));

            return c;
        }

        public List<Categoria> mostrarActivas()
        {

            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();

            if (dc.Categorias.IsNullOrEmpty())
            {
                return this.listaCategoria();
            }
            else
            {
                return dc.Categorias
                         .Where(c => c.Activo == "si")
                         .ToList();
            }
        }
        public List<Categoria> mostrarInactivas()
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            if (dc.Categorias.IsNullOrEmpty())
            {
                return this.listaCategoria();
            }
            else
            {
                return dc.Categorias
                         .Where(c => c.Activo != "si")
                         .ToList();
            }
        }

        public List<Categoria> buscarPorDescripcion(string descripcion)
        {
            using (var context = new DbPharmaSuiteContext())
            {

                var categorias = context.Categorias
                                        .Where(c => EF.Functions.Like(c.Descripcion, "%" + descripcion + "%"))
                                        .ToList();
                return categorias;
            }
        }
    }

}
