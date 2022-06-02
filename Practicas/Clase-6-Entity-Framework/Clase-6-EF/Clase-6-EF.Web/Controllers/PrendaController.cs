using Clase_6_EF.Data.EF;
using Clase_6_EF.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase_6_EF.Web.Controllers
{
    public class PrendaController : Controller
    {
        private IPrendaServicio _prendaServicio;

        public PrendaController(IPrendaServicio prendaServicio)
        {
            _prendaServicio = prendaServicio;
        }

        [HttpGet]
        public IActionResult PorLocal(int id)
        {
            List<Prendum> prendasLocal = _prendaServicio.ObtenerPorLocal(id);
            return View(prendasLocal);
        }
    }
}
