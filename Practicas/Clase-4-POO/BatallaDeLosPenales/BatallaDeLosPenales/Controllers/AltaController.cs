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

		public IActionResult Delantero()
		{
			return View();
		}

		public IActionResult DirectorTecnico()
		{
			return View();
		}

		[HttpPost]
		public IActionResult ProcesarArquero()
		{
			if (ValidarFormArquero())
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
				return Redirect("/alta/arquero");
			} else
			{
				TempData["ArqueroNoAgregado"] = "Ocurrio un error al agregar al arquero, intente nuevamente.";
				return Redirect("/alta/arquero");
			}

			
		}

		public bool ValidarFormArquero()
		{
			string nombre = Request.Form["Nombre"];
			string apellido = Request.Form["Apellido"];
			string expulsado = Request.Form["Expulsado"];
			string penalesAtajados = Request.Form["PenalesAtajados"];

			return (expulsado != null && penalesAtajados != null && nombre != null && apellido != null)
				   && (Request.Form["Expulsado"] == "si" || Request.Form["Expulsado"] == "no")
				   && (int.TryParse(Request.Form["PenalesAtajados"], out _));
		}
	}
}
