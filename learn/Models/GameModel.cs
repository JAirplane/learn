using System.ComponentModel.DataAnnotations;

namespace learn.Models
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
        public List<GamesGenres> GamesGenres { get; set; } = new();
        [Required]
        public DateTime? ReleaseDate { get; set; }
        public string? ImageLink { get; set; }
    }
}
