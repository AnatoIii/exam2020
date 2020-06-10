using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System.Linq;

namespace DAL
{
	public class ShopDBContext : DbContext
	{
		public ShopDBContext(DbContextOptions options) : base(options)
		{
			if (Database.GetPendingMigrations().Count() > 0) {
				Database.Migrate();
			}
		}

		public DbSet<Department> Departments { get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<DepartmentProduct> DeparmentProducts { get; set; }
	}
}
