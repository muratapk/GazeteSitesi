using System.ComponentModel.DataAnnotations;

namespace GazeteSitesi.Models
{
	public class Resimler
	{
        [Key]
        public int ResimId { get; set; }
        public string ResimAd { get; set; } = string.Empty;

        public virtual List<Haberler>? Haberlers { get;set; }
    }
}
