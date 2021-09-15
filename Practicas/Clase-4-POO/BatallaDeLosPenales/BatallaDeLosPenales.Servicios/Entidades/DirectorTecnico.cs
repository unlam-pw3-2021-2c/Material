using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeLosPenales.Servicios.Entidades
{
    public class DirectorTecnico : IPuntuable
    {
        public int Puntos => Jugadores.Sum(jug=> jug.Puntos);

        public List<Jugador> Jugadores { get; set; }
    }
}
