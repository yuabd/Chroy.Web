using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChRoy.Repository
{
	public class Account
	{
		[Key]
		public int ID { get; set; }

		public string AccountName { get; set; }

		public decimal Amount { get; set; }

		public DateTime DateCreated { get; set; }

		public int UserID { get; set; }

		public virtual ICollection<Bill> Bills { get; set; }
	}
}
