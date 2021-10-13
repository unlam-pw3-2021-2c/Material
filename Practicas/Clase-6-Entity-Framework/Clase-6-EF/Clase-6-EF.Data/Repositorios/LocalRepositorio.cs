using Clase_6_EF.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_EF.Data.Repositorios
{
    public class LocalRepositorio
    {
        private Db_TiendaContext _ctx;

        public LocalRepositorio(Db_TiendaContext ctx)
        {
            _ctx = ctx;
        }

        public List<Local> ObtenerTodos()
        {
            return _ctx.Locals.OrderBy(o=> o.Nombre).ToList();
        }

    }
}
