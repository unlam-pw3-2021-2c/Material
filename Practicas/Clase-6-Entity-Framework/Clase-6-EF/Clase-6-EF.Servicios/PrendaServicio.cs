using Clase_6_EF.Data.EF;
using Clase_6_EF.Data.Repositorios;
using Clase_6_EF.Data.Repositorios.Interfaces;
using Clase_6_EF.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase_6_EF.Servicios
{
    public class PrendaServicio : IPrendaServicio
    {
        private IPrendaRepositorio _prendaRepo;

        public PrendaServicio(IPrendaRepositorio localRepo)
        {
            _prendaRepo = localRepo;
        }

        public void Agregar(Prendum Prenda)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int idPrenda)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Prendum Prenda)
        {
            throw new NotImplementedException();
        }

        public Prendum ObtenerPorId(int idPrenda)
        {
            throw new NotImplementedException();
        }

        public List<Prendum> ObtenerPorLocal(int idLocal)
        {
            return _prendaRepo.ObtenerPorLocal(idLocal);
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
