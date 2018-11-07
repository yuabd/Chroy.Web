using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChRoy.Repository
{
    public class User
    {
		[Key]
		public int UserID { get; set; }

		public string UserName { get; set; }

		public string Password { get; set; }

		public string Name { get; set; }
	}
}
