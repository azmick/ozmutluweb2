using System.Data.Entity;

namespace ozmutluweb.Models.Siniflar
{
    public class Context : DbContext //DbContext i context sınıfından miras aldım
    {
      public DbSet<Admin> Admins { get; set; } //Hangi sınıfımı kullanmak istediğimi dbset icine yazıyorum.
      public DbSet<AdresBlog> AdresBlogs { get; set; }
      public DbSet<Urunler> Urunlers { get; set; }
      public DbSet<Hakkımızda> Hakkımızdas { get; set; }
      public DbSet<Iletisim> Iletisims { get; set; }
      public DbSet<Yorumlar> Yorumlars { get; set; }

    }
}
