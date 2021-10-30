using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionVentasV2.Controllers
{
    public class AdminEstablecimientoController : Controller
    {
        public IActionResult Index()
        {
            int EstablecimientoId = 0;

            if (HttpContext.Session.Get("EstablecimientoId") != null)
            {
                if(EstablecimientoId >0)
                EstablecimientoId = (int)HttpContext.Session.GetInt32("EstablecimientoId");
                ViewBag.Establecimiento = HttpContext.Session.GetString("EstablecimientoNombre");
                return View();
            }
            else
            {
                return Redirect("~/User/Login");
            }
        }
    }
}
