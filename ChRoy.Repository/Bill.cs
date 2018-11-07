using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChRoy.Repository
{
	public class Bill
	{
		[Key]
		public int ID { get; set; }
		/// <summary>
		/// 账户id
		/// </summary>
		public int AccountID { get; set; }
		/// <summary>
		/// 科目id
		/// </summary>
		public int CategoryID { get; set; }
		/// <summary>
		/// 往来对象id
		/// </summary>
		public int ContactID { get; set; }
		/// <summary>
		/// 摘要
		/// </summary>
		[MaxLength(300)]
		public string Remark { get; set; }
		/// <summary>
		/// 0支出，1收入
		/// </summary>
		public int Type { get; set; }
		/// <summary>
		/// 发生金额
		/// </summary>
		public decimal Amount { get; set; }
		/// <summary>
		/// 备注
		/// </summary>
		[MaxLength(500)]
		public string Description { get; set; }
		/// <summary>
		/// 账单发生时间
		/// </summary>
		public DateTime Time { get; set; }
		/// <summary>
		/// 记账时间
		/// </summary>
		public DateTime DateCreated { get; set; }

		public int UserID { get; set; }

		public virtual Account Account { get; set; }

		public virtual User User { get; set; }

		public virtual Contact Contact { get; set; }

		public virtual Category Category { get; set; }
	}
}
