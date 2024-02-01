namespace DataAccess.Models
{
	public class GameDeveloper
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Image {  get; set; } = string.Empty;
		public string StudioDescription { get; set; } = string.Empty;

        public IEnumerable<GameModel>? Games { get; set; }
    }
}
