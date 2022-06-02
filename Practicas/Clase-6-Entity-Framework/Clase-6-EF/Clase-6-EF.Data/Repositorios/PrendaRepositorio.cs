using Clase_6_EF.Data.EF;
using Clase_6_EF.Data.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_EF.Data.Repositorios
{
    public class PrendaRepositorio : IPrendaRepositorio
    {
        private Db_TiendaContext _ctx;

        public PrendaRepositorio(Db_TiendaContext ctx)
        {
            _ctx = ctx;
        }

        public void Agregar(Prendum prenda)
        {
            throw new NotImplementedException();
        }

        public void Borrar(Prendum prenda)
        {
            throw new NotImplementedException();
        }

        public Prendum ObtenerPorId(int idPrenda)
        {
            throw new NotImplementedException();
        }

        public List<Prendum> ObtenerPorLocal(int idLocal)
        {
            var localPrenda = _ctx.LocalPrenda.Where(lp => lp.IdLocal == idLocal);
            return localPrenda.Select(lp => lp.IdPrendaNavigation).ToList();
        }

        public List<Prendum> ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
