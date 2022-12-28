using System.ComponentModel.DataAnnotations;

namespace ozmutluweb.Models.Siniflar
{
    public class Hakkımızda
    {
        [Key]
        public int ID { get; set; }
        public string? FotoUrl { get; set; }
        public string Aciklama { get; set; }

    }
}
