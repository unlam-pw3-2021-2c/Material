using BD.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Servicios
{
    public class RazaService : IRazaService
    {
        public _20212cEjemplo2ParcialContext _ctx { get; set; }
        public RazaService(_20212cEjemplo2ParcialContext ctx)
        {
            _ctx = ctx;
        }

        public List<Raza> ObtenerTodos()
        {
            return _ctx.Razas.OrderBy(p => p.Nombre).ToList();
        }

        public void Crear(Raza raza)
        {
            _ctx.Razas.Add(raza);
            _ctx.SaveChanges();
        }
    }
}
