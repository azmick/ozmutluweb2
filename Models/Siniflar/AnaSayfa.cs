using System.ComponentModel.DataAnnotations;

namespace ozmutluweb.Models.Siniflar
{
    //Code first sınıfları olusturuyoruz.
    public class AnaSayfa //class yani tablolarımızı olusturup prop. yani özellikler ekliyoruz.
    {
        [Key]
        public int ID { get; set; }
        public string? Baslik { get; set; }
        public string? Aciklama { get; set; }
    }
}
