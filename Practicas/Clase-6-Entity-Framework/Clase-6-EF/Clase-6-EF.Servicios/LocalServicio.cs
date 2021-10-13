using Clase_6_EF.Data.EF;
using Clase_6_EF.Data.Repositorios;
using System;
using System.Collections.Generic;

namespace Clase_6_EF.Servicios
{
    public class LocalServicio
    {
        private LocalRepositorio _localRepo;

        public LocalServicio(LocalRepositorio localRepo)
        {
            _localRepo = localRepo;
        }

        public List<Local> ObtenerTodos()
        {
            return _localRepo.ObtenerTodos();
        }
    }
}
