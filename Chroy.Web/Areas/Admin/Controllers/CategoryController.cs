using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChRoy.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Chroy.Web.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
	{
		private MyDbContext db;
		public CategoryController(MyDbContext _context)
		{
			db = _context;
		}

		public IActionResult Index()
        {
            return View();
        }

		public IActionResult Get()
		{
			var list = db.Categories.ToList();

			return Json(list);
		}
    }
}