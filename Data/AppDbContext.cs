using ContractManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ContractManager.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Dyspozycja> Dyspozycje { get; set; }
	}
}
