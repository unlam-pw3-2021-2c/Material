﻿using Clase_6_EF.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_EF.Servicios.Interfaces
{
    public interface ILocalServicio
    {
        public List<Local> ObtenerTodos();
    }
}