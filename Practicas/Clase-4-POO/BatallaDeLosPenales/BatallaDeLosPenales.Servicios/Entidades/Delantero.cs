using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeLosPenales.Servicios.Entidades
{
    public class Delantero : Jugador
    {
        public int PenalesConvertidos { get; set; }
        protected override int CalcularPuntos()
        {
            return PenalesConvertidos * 75;
        }
    }
}
