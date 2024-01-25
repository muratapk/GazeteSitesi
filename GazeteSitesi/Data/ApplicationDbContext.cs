using GazeteSitesi.Models;
using Microsoft.EntityFrameworkCore;

namespace GazeteSitesi.Data
{
	public class ApplicationDbContext : DbContext
	{
		public  ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
		{
		}
		public DbSet<Haberler> haberlers { get; set; }
		public DbSet<Reklamlar> Reklamlars { get; set; }
		public DbSet<Yorumlar> Yorumlars { get; set; }
		public DbSet<Kullanicilar> Kullanicilars { get; set; }
		public DbSet<Yazarlar> Yazarlars { get; set; }
		public DbSet<Yetkiler> Yetkilers { get; set; }
		public DbSet<Kategoriler> Kategorilers { get; set; }
		public DbSet<Gazete> Gazetes { get; set; }
		public DbSet<Konumlar> Konumlars { get; set; }
		public DbSet<Resimler> Resimlers { get; set; }


	}
}
