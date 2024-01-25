using System.ComponentModel.DataAnnotations;

namespace GazeteSitesi.Models
{
	public class Reklamlar
	{
        [Key]
        public int ReklamId { get; set; }
        public string ReklamKonu { get; set; } = string.Empty;
        public string ReklamResim { get; set; } = string.Empty;
        public int KonumId { get; set; }
        public virtual Konumlar? Konumlar { get; set; }
    }
}
