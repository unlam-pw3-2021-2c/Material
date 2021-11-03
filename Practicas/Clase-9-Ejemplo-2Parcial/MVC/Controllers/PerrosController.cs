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
        public PerrosController(IPerroService perroService)
        {
            _perroService = perroService;
        }
        public ActionResult Crear()
        {
            return View();
        }

        // POST: PerrosController/Create
        [HttpPost]
        public ActionResult Crear(Perro perro)
        {
            try
            {
                perro.IdRaza = 1;
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
