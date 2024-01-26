using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GazeteSitesi.Models
{
	public class Kullanicilar
	{
		[Key]
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }

        [ForeignKey("Yetkiler")]
        public int ? YetkiId { get; set; }
        public virtual Yetkiler ? Yetkiler { get; set; }
    }
}
