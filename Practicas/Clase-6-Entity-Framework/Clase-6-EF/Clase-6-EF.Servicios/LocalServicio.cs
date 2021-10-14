using Clase_6_EF.Data.EF;
using Clase_6_EF.Data.Repositorios;
using Clase_6_EF.Data.Repositorios.Interfaces;
using Clase_6_EF.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace Clase_6_EF.Servicios
{
    public class LocalServicio : ILocalServicio
    {
        private ILocalRepositorio _localRepo;

        public LocalServicio(ILocalRepositorio localRepo)
        {
            _localRepo = localRepo;
        }

        public List<Local> ObtenerTodos()
        {
            return _localRepo.ObtenerTodos();
        }

        public void Agregar(Local local)
        {
            _localRepo.Agregar(local);
            _localRepo.SaveChanges();
        }
    }
}
