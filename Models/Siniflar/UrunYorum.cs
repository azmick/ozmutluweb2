using Microsoft.AspNetCore.Mvc.ViewFeatures;


namespace ozmutluweb.Models.Siniflar
{
	public class UrunYorum //Hangi tablolarımdan veri çekiceksem, işlem yapıcaksam o tabloları enumerable olarak topladık
	{
		public IEnumerable<Urunler>? Deger1 { get; set;}
		public IEnumerable<Yorumlars>? Deger2 { get; set;}

		public IEnumerable<Urunler>? Deger3 { get; set; }

	}
}
