using learn.Models;

namespace learn.Data.Repository
{
	public interface IRepository
	{
		public List<GameModel> GetAllGames();
		bool CreateNewGame(GameModel newGame);
		GameModel GetGameById(int id);
		public List<Genre> GetAllGenres();
		public Genre GetGenreById(int id);
		public bool EditGenre(Genre editedGenre);
	}
}
