using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeLosPenales.Servicios.Entidades
{
    public class Arquero : Jugador
    {
        public int PenalesAtajados { get; private set; }
        public Arquero()
        {

        }
        public Arquero(int id, string nombre, string apellido, bool expulsado, int penalesAtajados) : base(id, nombre, apellido, expulsado)
        {
            PenalesAtajados = penalesAtajados;
        }

        protected override int CalcularPuntos()
        {
            return PenalesAtajados * 100;
        }
    }
}
