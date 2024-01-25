using System.ComponentModel.DataAnnotations;

namespace GazeteSitesi.Models
{
	public class Yorumlar
	{
        [Key]
        public int YorumId { get; set; }
        public string YorumAd { get; set; } = string.Empty;
        public string YorumMesaj { get; set; } = string.Empty;
        public int HaberId { get; set; }
        public virtual Haberler? Haberler { get; set; }
    }
}
