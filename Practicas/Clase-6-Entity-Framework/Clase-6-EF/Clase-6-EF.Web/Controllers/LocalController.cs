using Clase_6_EF.Data.EF;
using Clase_6_EF.Servicios;
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
        // GET: LocalController
        public ActionResult Lista()
        {
            Db_TiendaContext ctx = new Db_TiendaContext();
            Data.Repositorios.LocalRepositorio localRepo = new Data.Repositorios.LocalRepositorio(ctx);
            LocalServicio localServicio = new LocalServicio(localRepo);

            List<Local> locales = localServicio.ObtenerTodos();

            return View(locales);
        }

    }
}
