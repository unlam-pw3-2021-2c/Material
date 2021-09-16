using BatallaDeLosPenales.Servicios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeLosPenales.Servicios.Servicios
{
    public class DirectorTecnicoServicio : EntidadesManager<DirectorTecnico>
    {
        public static List<DirectorTecnico> ObtenerTecnicosMayorPuntaje()
        {
            int maxPuntos = Lista.Max(o => o.Puntos);
            return Lista.Where(o => o.Puntos == maxPuntos).ToList();
        }
    }
}
