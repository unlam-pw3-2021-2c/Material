using Clase_6_EF.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_EF.Servicios.Interfaces
{
    public interface IPrendaServicio
    {
        public List<Prendum> ObtenerTodos();
        public void Agregar(Prendum Prenda);
        public Prendum ObtenerPorId(int idPrenda);
        public List<Prendum> ObtenerPorLocal(int idLocal);
        public void Borrar(int idPrenda);
        public void SaveChanges();
        public void Modificar(Prendum Prenda);
    }
}
