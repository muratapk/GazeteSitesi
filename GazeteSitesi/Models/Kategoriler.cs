using System.ComponentModel.DataAnnotations;

namespace GazeteSitesi.Models
{
	public class Kategoriler
	{
        [Key]
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; } = string.Empty;
		public virtual ICollection<Haberler>? Haberlers { get; set; }
	}
}
