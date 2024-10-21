using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PharmaSuite.Logica.Query
{
    internal class QueryProducto
    {
        public List<Producto> listaProductos()
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();

            if (dc.Productos.IsNullOrEmpty())
            {
                return new List<Producto>();
            }
            else
            {
                return new List<Producto>(dc.Productos);
            }
        }
        
        public List<Producto> listaProductosInactivos()
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();

            if (dc.Productos.IsNullOrEmpty())
            {
                return this.listaProductos();
            }
            else
            {
                    return dc.Productos
                         .Where(c => c.Activo != "si")
                         .ToList(); 
            }
        }

        public List<Producto> listaProductosActivos()
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();

            if (dc.Productos.IsNullOrEmpty())
            {
                return this.listaProductos();
            }
            else
            {
                return dc.Productos
                     .Where(c => c.Activo == "si")
                     .ToList();
            }
        }
        public List<Producto> listaNombreCodBarra(string cadena)
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext(); 
            List<Producto> lista = dc.Productos
                .Where(p => p.CodBarra.ToString().Contains(cadena) ||
                    p.NombreProd.Contains(cadena))
                .ToList();

            return lista;
        }

        public Producto buscarCodBarra(int codBarra)
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            return dc.Productos.SingleOrDefault(p => p.CodBarra.Equals(codBarra));
        }
        public Producto buscarNombre(string nombreProducto)
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            return dc.Productos.SingleOrDefault(p => p.NombreProd.Equals(nombreProducto));
        }





    }
}
