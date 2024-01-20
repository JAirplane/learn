using learn.Models;

namespace learn.Data.Repository
{
	public interface IRepository
	{
		public List<GameModel> GetAllGames();
	}
}
