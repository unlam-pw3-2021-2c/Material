using BD.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class PerrosController : Controller
    {
        private IPerroService _perroService;
        private IRazaService _razaService;
        public PerrosController(IPerroService perroService, IRazaService razaService)
        {
            _perroService = perroService;
            _razaService = razaService;
        }
        public ActionResult Crear()
        {
            ViewBag.Razas = _razaService.ObtenerTodos();
            return View();
        }

        // POST: PerrosController/Create
        [HttpPost]
        public ActionResult Crear(Perro perro)
        {
            try
            {
                _perroService.Crear(perro);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }

    }
}
