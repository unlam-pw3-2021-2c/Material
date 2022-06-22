﻿using BatallaDeLosPenales.Servicios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeLosPenales.Servicios.Servicios
{
    public class EntidadesManager<T> where T : Entidad
    {
        protected static List<T> Lista { get; set; } = new List<T>();

        public static void Agregar(T j)
        {
			j.Id = Lista.Count > 0 ? Lista.Max(x => x.Id) + 1 : 1;
			Lista.Add(j);
        }

        public static T ObtenerPorId(int id)
        {
            return Lista.First(j => j.Id == id);
        }

        public static List<T> ObtenerTodos()
        {
            return Lista;
        }
    }
}
