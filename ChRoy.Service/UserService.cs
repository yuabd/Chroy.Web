using ChRoy.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChRoy.Service
{
    public class UserService
    {
		//获取数据库连接字符串

		private MyDbContext db;

		public UserService(MyDbContext _context)
		{
			db = _context;
		}

		public void AddUser(User Model)
		{
			db.Uesrs.Add(Model);
			db.SaveChanges();
		}

		public IEnumerable<User> GetLists()
		{
			return db.Uesrs;
		}
	}
}
