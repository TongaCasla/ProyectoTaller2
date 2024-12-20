﻿using PharmaSuite.Modelo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PharmaSuite.Logica.Query
{
    class QueryUsuario
    {
        public Usuario bucarNombre(string nombre)
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            Usuario us = new Usuario();
            us = dc.Usuarios.SingleOrDefault(s => s.Nombre.Equals(nombre));

            return us;
        }

        public Usuario buscarPorIdPers(int id)
        {
            DbPharmaSuiteContext dc = new DbPharmaSuiteContext();
            return dc.Usuarios.SingleOrDefault(s => s.IdPersona.Equals(id));

        }
        public Usuario buscarPorId(int id)
        {
            using (DbPharmaSuiteContext dc = new DbPharmaSuiteContext())
            {
                return dc.Usuarios.SingleOrDefault(s => s.IdUsuario.Equals(id));
            }
        }
    }
}
