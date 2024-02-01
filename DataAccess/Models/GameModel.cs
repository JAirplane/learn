using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
	public class GameModel
	{
		public int Id { get; set; }
		[Required]
		[MinLength(3), MaxLength(50)]
		public string Name { get; set; }
		[Required]
		[MinLength(3), MaxLength(500)]
		public string Description { get; set; }
		public bool InSale { get; set; }
		public string? GamePlayVideo { get; set; }
		[Required]
		public DateTime? ReleaseDate { get; set; }
		public string? ImageLink { get; set; }
		//Foreign key
        public int? DeveloperId { get; set; }
		//Navigation property
		[ForeignKey(nameof(DeveloperId))]
        public GameDeveloper? Developer { get; set; }
		public IEnumerable<Genre> Genres { get; set; }
    }
}
