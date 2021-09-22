using BatallaDeLosPenales.Servicios.Entidades;
using BatallaDeLosPenales.Servicios.Servicios;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatallaDeLosPenales.Controllers
{
	public class AltaController : Controller
	{
		public IActionResult Arquero()
		{
			if (TempData["ArqueroAgregado"] != null)
				ViewBag.ArqueroAgregado = TempData["ArqueroAgregado"].ToString();

			if (TempData["ArqueroNoAgregado"] != null)
				ViewBag.ArqueroNoAgregado = TempData["ArqueroNoAgregado"].ToString();

			return View();
		}

		[HttpPost]
		public IActionResult ProcesarArquero()
		{
			if (ValidarFormJugador() && ValidarInputPenales("PenalesAtajados"))
			{
				bool expulsado = Request.Form["Expulsado"] == "si" ? true : false;
				int penalesAtajados = int.Parse(Request.Form["PenalesAtajados"]);

				Arquero arquero = new Arquero(
					Request.Form["Nombre"],
					Request.Form["Apellido"],
					expulsado,
					penalesAtajados
				);

				ArqueroServicio.Agregar(arquero);

				TempData["ArqueroAgregado"] = "Arquero agregado correctamente.";
			}
			else
			{
				TempData["ArqueroNoAgregado"] = "Ocurrio un error al agregar al arquero, intente nuevamente.";
			}

			return Redirect("/alta/arquero");
		}

		public IActionResult Delantero()
		{
			if (TempData["DelanteroAgregado"] != null)
				ViewBag.DelanteroAgregado = TempData["DelanteroAgregado"].ToString();

			if (TempData["DelanteroNoAgregado"] != null)
				ViewBag.DelanteroNoAgregado = TempData["DelanteroNoAgregado"].ToString();

			return View();
		}

		[HttpPost]
		public IActionResult ProcesarDelantero()
		{
			if (ValidarFormJugador() && ValidarInputPenales("PenalesConvertidos"))
			{
				bool expulsado = Request.Form["Expulsado"] == "si" ? true : false;
				int penalesConvertidos = int.Parse(Request.Form["PenalesConvertidos"]);

				Delantero delantero = new Delantero(
					Request.Form["Nombre"],
					Request.Form["Apellido"],
					expulsado,
					penalesConvertidos
				);

				DelanteroServicio.Agregar(delantero);

				TempData["DelanteroAgregado"] = "Delantero agregado correctamente.";
			}
			else
			{
				TempData["DelanteroNoAgregado"] = "Ocurrio un error al agregar al delantero, intente nuevamente.";
			}

			return Redirect("/alta/delantero");
		}

		public IActionResult DirectorTecnico()
		{
			if (TempData["DirectorTecnicoAgregado"] != null)
				ViewBag.DirectorTecnicoAgregado = TempData["DirectorTecnicoAgregado"].ToString();

			if (TempData["DirectorTecnicoNoAgregado"] != null)
				ViewBag.DirectorTecnicoNoAgregado = TempData["DirectorTecnicoNoAgregado"].ToString();

			ViewBag.Arqueros = ArqueroServicio.ObtenerTodos();
			ViewBag.Delanteros = DelanteroServicio.ObtenerTodos();

			return View();
		}

		[HttpPost]
		public IActionResult ProcesarDirectorTecnico()
		{
			if (ValidarFormDirectorTecnico())
			{
				string nombreUsuario = Request.Form["NombreUsuario"];

				int arqueroId = int.Parse(Request.Form["Arquero"]);
				int delantero1Id = int.Parse(Request.Form["Delantero1"]);
				int delantero2Id = int.Parse(Request.Form["Delantero2"]);

				Arquero arquero = ArqueroServicio.ObtenerPorId(arqueroId);
				Delantero delantero1 = DelanteroServicio.ObtenerPorId(delantero1Id);
				Delantero delantero2 = DelanteroServicio.ObtenerPorId(delantero2Id);

				List<Jugador> listaJugadores = new List<Jugador>();
				listaJugadores.Add(arquero);
				listaJugadores.Add(delantero1);
				listaJugadores.Add(delantero2);

				DirectorTecnico dt = new DirectorTecnico(nombreUsuario, listaJugadores);

				DirectorTecnicoServicio.Agregar(dt);

				TempData["DirectorTecnicoAgregado"] = "Director tecnico agregado correctamente.";
			} else
			{
				TempData["DirectorTecnicoNoAgregado"] = "Ocurrio un error al agregar al director tecnico, intente nuevamente.";
			}

			return Redirect("/alta/directortecnico");
		}

		public bool ValidarFormJugador()
		{
			string nombre = Request.Form["Nombre"];
			string apellido = Request.Form["Apellido"];
			string expulsado = Request.Form["Expulsado"];

			return ((expulsado != null && nombre != null && apellido != null)
				   && (Request.Form["Expulsado"] == "si" || Request.Form["Expulsado"] == "no"));
		}

		public bool ValidarInputPenales(string penalesAtajadosOConvertidos)
		{
			string penales = Request.Form[penalesAtajadosOConvertidos];
			return (penales != null && int.TryParse(Request.Form[penalesAtajadosOConvertidos], out _));
		}

		public bool ValidarFormDirectorTecnico()
		{
			string nombreUsuario = Request.Form["NombreUsuario"];
			string arquero = Request.Form["Arquero"];
			string delantero1 = Request.Form["Delantero1"];
			string delantero2 = Request.Form["Delantero2"];

			return ((nombreUsuario != null && arquero != null && delantero1 != null && delantero2 != null)
				   && int.TryParse(arquero, out _)
				   && int.TryParse(delantero1, out _)
				   && int.TryParse(delantero2, out _));
		}
	}
}
