using BatallaDeLosPenales.Servicios.Entidades;
using BatallaDeLosPenales.Servicios.Servicios;
using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace BatallaDeLosPenales.Test.Unit
{
    public class DirectorTecnicoServicioTest
    {
        [Fact]
        public void ObtenerTecnicosMayorPuntajeCorrecto()
        {
            Arquero arq1 = new Arquero(1, "Juan", "Carrizo", false, 1);//100
            Arquero arq2 = new Arquero(2, "Gato", "Sessa", true, 0);//-50
            Arquero arq3 = new Arquero(3, "Jose Luis Felix", "Chilavert", true, 3);//250

            Delantero del1 = new Delantero(4, "Turu", "Flores", true, 5);//350
            Delantero del2 = new Delantero(5, "Franco", "Soldano", false, 2);//150
            Delantero del3 = new Delantero(6, "Gomito", "Gomez", false, 3);//225
            Delantero del4 = new Delantero(7, "Pulga", "Rodriguez", false, 10);//750

            DirectorTecnico dt1 = new DirectorTecnico("Caruso Lombardi", new List<Jugador>() { arq1, del1, del2 });//100+350+150=600
            DirectorTecnico dt2 = new DirectorTecnico("D1eg0", new List<Jugador>() { arq2, del3, del4 });//-50+225+750=925
            DirectorTecnico dt3 = new DirectorTecnico("Bilardista", new List<Jugador>() { arq3, del1, del2 });//250+350+150=750
            DirectorTecnico dt4 = new DirectorTecnico("El Muñe", new List<Jugador>() { arq1, del4, del2 });//100+750+150=1000

            DirectorTecnicoServicio.Agregar(dt1);
            DirectorTecnicoServicio.Agregar(dt2);
            DirectorTecnicoServicio.Agregar(dt3);
            DirectorTecnicoServicio.Agregar(dt4);

            List<DirectorTecnico> dtMayorPuntaje = DirectorTecnicoServicio.ObtenerTecnicosMayorPuntaje();

            Assert.True(dtMayorPuntaje.Count == 1, "Se esperaba un solo tecnico con mayor puntaje");
            Assert.True(dtMayorPuntaje.First().NombreUsuario == dt4.NombreUsuario, $"Se esperaba que el tecnico con mayor puntaje fuera {dt4.NombreUsuario}");
        }
    }
}
