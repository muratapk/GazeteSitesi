using System.ComponentModel.DataAnnotations;

namespace GazeteSitesi.Models
{
	public class Yazarlar
	{
        [Key]
        public int YazarId { get; set; }
        public string YazarAd { get; set; } = string.Empty;
        public string YazarResim { get; set; } = string.Empty;
        public string YazarEmail { get; set; } = string.Empty;
        public string YazarSifre { get; set; } = string.Empty;
		public virtual ICollection<Haberler>? Haberlers { get; set; }
	}
}
