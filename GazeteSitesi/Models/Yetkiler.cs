using System.ComponentModel.DataAnnotations;

namespace GazeteSitesi.Models
{
	public class Yetkiler
	{
        [Key]
        public int YetkiId { get; set; }
        public string YetkiAdi { get; set; } = string.Empty;
        public virtual List<Kullanicilar>? Kullanicilars { get; set; }
    }
}
