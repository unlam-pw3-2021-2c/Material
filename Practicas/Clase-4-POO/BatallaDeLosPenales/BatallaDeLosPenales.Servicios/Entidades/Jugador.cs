using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeLosPenales.Servicios.Entidades
{
    public abstract class Jugador : Entidad, IPuntuable
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Expulsado { get; set; }
        public int Puntos
        {
            get
            {
                return CalcularPuntos() - PuntosExpulsado();
            }
        }

        public Jugador()
        {

        }
        public Jugador(int id, string nombre, string apellido, bool expulsado)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Expulsado = expulsado;
        }

        private int PuntosExpulsado()
        {
            return (Expulsado ? 50 : 0);
        }

        protected abstract int CalcularPuntos();
    }
}
