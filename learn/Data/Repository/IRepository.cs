using learn.Models;

namespace learn.Data.Repository
{
	public interface IRepository
	{
		public List<GameModel> GetAllGames();
		public List<Genre> GetAllGenres();
		public Genre GetGenreById(int id);
		public bool EditGenre(Genre editedGenre);
	}
}
