using System.ComponentModel.DataAnnotations;

namespace GazeteSitesi.Models
{
	public class Yetkiler
	{
        [Key]
        public int YetkiId { get; set; }
        public string YetkiAdi { get; set; } = string.Empty;
        public virtual ICollection<Kullanicilar>? Kullanicilars { get; set; }
    }
}
