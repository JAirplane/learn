using DataAccess;
using DataAccess.Models;

namespace learn.Data.Repository
{
	public class SqlRepository : IRepository
	{
		private readonly ApplicationDBContext db;

		public SqlRepository(ApplicationDBContext db)
		{
			this.db = db;
		}
		public bool CreateNewGame(GameModel newGame)
		{
			if (newGame == null)
			{
				return false;
			}
			db.Add(newGame);
			db.SaveChanges();
			return true;
		}

		public bool EditGenre(Genre editedGenre)
		{
			if (editedGenre == null)
			{
				return false;
			}
			db.Genres.Update(editedGenre);
			db.SaveChanges();
			return true;
		}

		public List<GameDeveloper> GetAllDevelopers()
		{
			var devs = db.GameDevelopers.ToList();
			return devs;
		}

		public List<GameModel> GetAllGames()
		{
			var games = db.GameModels.ToList();
			return games;
		}

		public List<Genre> GetAllGenres()
		{
			var genres = db.Genres.ToList();
			return genres;
		}

		public GameModel GetGameById(int id)
		{
			var game = db.GameModels.FirstOrDefault(x => x.Id == id);
			return game;
		}

		public Genre GetGenreById(int id)
		{
			throw new NotImplementedException();
		}
	}
}
