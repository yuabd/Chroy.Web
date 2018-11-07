using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChRoy.Repository;
using ChRoy.Service;
using Microsoft.AspNetCore.Mvc;

namespace Chroy.Web.Controllers
{
	public class UserController : Controller
	{
		private readonly UserService us;
		public UserController(UserService Context)
		{
			us = Context;
		}

		public IActionResult Index()
		{
			var list = us.GetLists().ToList();

			return View(list);
		}

		public IActionResult Add()
		{
			var user = new User();

			return View(user);
		}

		[HttpPost]
		public IActionResult AddSubmit(User user)
		{
			//db.Uesrs.Add(user);

			//db.SaveChanges();
			us.AddUser(user);

			TempData["msg"] = "添加成功";

			return View("Add", user);
		}

	}
}