using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GestionVentasV2.Data;

namespace GestionVentasV2.Controllers
{
	public class GeneralController : Controller
	{
		private readonly ApplicationDbContext _dbContext;

        public GeneralController(ApplicationDbContext Context)
        {
			_dbContext = Context;
        }
		public IActionResult Index()
		{
			//
			var estados = _dbContext.estados.ToList();

			return View();
		}

		public IActionResult About()
		{
			return View();
		}
	}
}
