using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChRoy.Repository
{
    public class Contact
    {
		[Key]
		public int ContactID { get; set; }

		public string ContactName { get; set; }

		public int UserID { get; set; }

		public virtual ICollection<Bill> Bills { get; set; }
	}
}
