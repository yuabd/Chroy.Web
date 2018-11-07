using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace ChRoy.Repository
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions<MyDbContext> options)
			: base(options)
		{
		}

		public virtual DbSet<User> Uesrs { get; set; }

		public virtual DbSet<Account> Accounts { get; set; }

		public virtual DbSet<Bill> Bills { get; set; }

		public virtual DbSet<Category> Categories { get; set; }

		public virtual DbSet<Contact> Contacts { get; set; }

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	base.OnConfiguring(optionsBuilder);
		//}
	}
	public static class SeedData
	{
		public static void Initialize(IServiceProvider scopedProvider)
		{
			
		}
	}

}