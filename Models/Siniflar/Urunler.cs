using System.ComponentModel.DataAnnotations;

namespace ozmutluweb.Models.Siniflar
{
    public class Urunler
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; } //Urun eklendigi zaman.
        public string Aciklama { get; set; }
        public string UrunImage { get; set; }

    }
}
