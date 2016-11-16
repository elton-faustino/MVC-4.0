using MVC.BLL;
using MVC.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MVC.DTO;


namespace MVC.UI.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            var login = new LoginViewModel() { ErrorMessage = string.Empty };

            return View(login);
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel login)
        {
            try
            {
                var ent = Mapper.Map<LoginViewModel, Login>(login);

                new LoginBLL().Logar(ent);

                return RedirectToAction("Index", "Usuarios");
            }
            catch (Exception ex)
            {
                login.ErrorMessage = ex.Message;
                return View(login);
            }
        }
    }
}
