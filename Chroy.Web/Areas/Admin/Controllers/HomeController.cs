using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChRoy.Repository;

namespace Chroy.Web.Areas.Admin.Controllers
{
	public class HomeController : BaseController
	{
		private MyDbContext db;
		public HomeController(MyDbContext _context)
		{
			db = _context;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}