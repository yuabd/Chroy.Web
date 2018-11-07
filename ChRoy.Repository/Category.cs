using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChRoy.Repository
{
	public class Category
	{
		[Key]
		public int CategoryID { get; set; }

		public string CategoryName { get; set; }

		public int ParentID { get; set; }

		public int UserID { get; set; }

		public virtual ICollection<Bill> Bills { get; set; }
	}
}
