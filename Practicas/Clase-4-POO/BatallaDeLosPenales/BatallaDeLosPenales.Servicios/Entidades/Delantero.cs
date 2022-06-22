using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeLosPenales.Servicios.Entidades
{
    public class Delantero : Jugador
    {
        public int PenalesConvertidos { get; private set; }

        public Delantero()
        {

        }

		public Delantero(string nombre, string apellido, bool expulsado, int penalesConvertidos) : base(nombre, apellido, expulsado)
		{
			PenalesConvertidos = penalesConvertidos;
		}

		public Delantero(int id, string nombre, string apellido, bool expulsado, int penalesConvertidos) : base(id, nombre, apellido, expulsado)
        {
            PenalesConvertidos = penalesConvertidos;
        }

        protected override int CalcularPuntos()
        {
            return PenalesConvertidos * 75;
        }
    }
}
