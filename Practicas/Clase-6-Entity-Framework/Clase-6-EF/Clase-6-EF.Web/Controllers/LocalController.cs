using Clase_6_EF.Data.EF;
using Clase_6_EF.Servicios;
using Clase_6_EF.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase_6_EF.Web.Controllers
{
    public class LocalController : Controller
    {
        private ILocalServicio _localServicio;

        public LocalController(ILocalServicio localServicio)
        {
            _localServicio = localServicio;
        }
        // GET: LocalController
        public ActionResult Lista()
        {
            //Db_TiendaContext ctx = new Db_TiendaContext();
            //Data.Repositorios.LocalRepositorio localRepo = new Data.Repositorios.LocalRepositorio(ctx);
            //LocalServicio localServicio = new LocalServicio(localRepo);

            List<Local> locales = _localServicio.ObtenerTodos();

            return View(locales);
        }

        [HttpGet]
        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(Local local)
        {
            _localServicio.Agregar(local);
            return Redirect("/local/lista");
        }
    }
}
