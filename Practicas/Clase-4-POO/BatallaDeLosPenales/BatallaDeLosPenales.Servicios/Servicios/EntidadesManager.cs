using BatallaDeLosPenales.Servicios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeLosPenales.Servicios.Servicios
{
    public class EntidadesManager<T> where T : Entidad
    {
        private List<T> Lista { get; set; } = new List<T>();

        public void Agregar(T j)
        {
            Lista.Add(j);
        }

        public T ObtenerPorId(int id)
        {
            return Lista.First(j => j.Id == id);
        }

        public List<T> ObtenerTodos()
        {
            return Lista;
        }
    }
}
