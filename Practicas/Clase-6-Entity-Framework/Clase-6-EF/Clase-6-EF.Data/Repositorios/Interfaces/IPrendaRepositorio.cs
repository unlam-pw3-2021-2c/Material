using Clase_6_EF.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_EF.Data.Repositorios.Interfaces
{
    public interface IPrendaRepositorio
    {
        public List<Prendum> ObtenerTodos();
        public void Agregar(Prendum prenda);
        public Prendum ObtenerPorId(int idPrenda);
        public List<Prendum> ObtenerPorLocal(int idLocal);
        public void Borrar(Prendum prenda);
        public void SaveChanges();
    }
}
