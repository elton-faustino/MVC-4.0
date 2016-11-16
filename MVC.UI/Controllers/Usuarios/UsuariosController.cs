using MVC.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Controllers
{
    public class UsuariosController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            var users = new UsuariosViewModel();

            return View("~/Views/Usuarios/Usuarios.cshtml", users);
        }

    }
}
