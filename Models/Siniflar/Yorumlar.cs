using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ozmutluweb.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public String? KullaniciAdi { get; set; }
        public String? Mail { get; set; } //Burada amac veri toplamak. Kullaniciların mailine yeni bir bilidirim atarken bu verilere göre islem yapabiliriz.
        public String? Yorum { get; set; }
        public int? Urunlerid { get; set; }
        public virtual Urunler? Urunler { get; set; } //Yapilan yorumun hangi ürüne yapildi tutmak icin.
    }
}
