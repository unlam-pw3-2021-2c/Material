using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeLosPenales.Servicios.Entidades
{
    public class Arquero : Jugador
    {
        public int PenalesAtajados { get; set; }
        protected override int CalcularPuntos()
        {
            return PenalesAtajados * 100;
        }
    }
}
