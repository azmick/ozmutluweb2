using Microsoft.EntityFrameworkCore;

namespace ozmutluweb.Models.Siniflar
{
    public class Context : DbContext //DbContext i context sınıfından miras aldım
    {
        private readonly IConfiguration _config;

		public Context()
		{
		}

		public Context(IConfiguration config)
        {
            _config = config;
        }

        public DbSet<Admin> Admins { get; set; } //Hangi sınıfımı kullanmak istediğimi dbset icine yazıyorum.
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Hakkımızda> Hakkimizdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Yorumlars> Yorumlars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=gorkemliDB;Trusted_Connection=True;");
        }
    }
}




