
using learn.Models;

namespace learn.Data.Repository
{
	public class GamesRepository : IRepository
	{
		private List<GameModel> gamesCollection;
		public GamesRepository()
		{
			gamesCollection = new List<GameModel>()
			{
				new()
				{
					Id = 1,
					Name = "Cities SkyLine",
					Genre = "Simulator",
					ReleaseDate = new DateTime(2013, 10, 15),
					ImageLink = "https://i.playground.ru/e/xRfN9CSoRzIfJ4zwIQHQdw.jpeg"
				},
				new()
				{
					Id = 2,
					Name = "The Witcher 3",
					Genre = "Action/RPG",
					ReleaseDate = new DateTime(2016, 05, 18),
					ImageLink = "https://upload.wikimedia.org/wikipedia/ru/archive/a/a2/20201101185506%21The_Witcher_3-_Wild_Hunt_Cover.jpg"

				},
				new()
				{
					Id = 3,
					Name = "They are billion!",
					Genre = "Strategy",
					ReleaseDate = new DateTime(2019, 03, 10),
					ImageLink = "https://lh3.googleusercontent.com/proxy/Xl23VNEXPmlyIJTlAWSf4mzl8pbJ4LNkaRxR2RXNnHRku72FodfbBa0moHOMBZVkEq7mzH4Y4V6fdo0cRzeA6WrxvEV4E1cLjAGU"
				}
			};
		}
		public List<GameModel> GetAllGames()
		{
			return gamesCollection;
		}
	}
}
