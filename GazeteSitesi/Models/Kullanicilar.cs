using System.ComponentModel.DataAnnotations;

namespace GazeteSitesi.Models
{
	public class Kullanicilar
	{
		[Key]
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public int YetkiId { get; set; }
        public virtual Yetkiler? Yetkiler { get; set; }
    }
}
