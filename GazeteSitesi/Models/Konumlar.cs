using System.ComponentModel.DataAnnotations;

namespace GazeteSitesi.Models
{
	public class Konumlar
	{
        [Key]
        public int KonumId { get; set; }
        public string KonumAdi { get; set; } = string.Empty;
        public virtual List<Haberler>?Haberlers { get; set; }
        public virtual List<Reklamlar>? Reklamlars { get; set; }
    }
}
