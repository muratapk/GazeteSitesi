using System.ComponentModel.DataAnnotations;

namespace GazeteSitesi.Models
{
	public class Haberler
	{
		[Key]
        public int HaberId { get; set; }
		public string HaberBaslik { get; set; } = string.Empty;
		public string HaberKonu { get; set; } = string.Empty;

		public string HaberIcerik { get; set; } = string.Empty;
		public int ResimId { get; set; }
		public virtual Resimler? Resimler { get; set; }
        public int KategoriId { get; set; }
		public virtual Kategoriler? Kategoriler { get; set; }
        public int YazarId { get; set; }
		public virtual Yazarlar? Yazarlar { get; set; }
		public DateTime HaberTarih { get; set; }
        public int HaberManset { get; set; }
		public int KonumId { get; set; }
		public virtual Konumlar? Konumlar { get; set; }
		public virtual ICollection<Yorumlar>? Yorumlars { get; set; }
    }
}
