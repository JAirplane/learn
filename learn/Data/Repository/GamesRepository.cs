
using learn.Models;

namespace learn.Data.Repository
{
	public class GamesRepository : IRepository
	{
		private List<GameModel> gamesCollection;
		private List<Genre> genreCollection;
		private List<GameDeveloper> devsCollection;
		public GamesRepository()
		{
			genreCollection = new List<Genre>()
			{
				new()
				{
					Id = 1,
					Name = "RPG"
				},
				new()
				{
					Id = 2,
					Name = "Action"
				},
				new()
				{
					Id = 3,
					Name = "Horror"
				},
				new()
				{
					Id = 4,
					Name = "Platformer"
				},
				new()
				{
					Id = 5,
					Name = "Simulator"
				}
			};

			gamesCollection = new List<GameModel>()
			{
				new()
				{
					Id = 1,
					Name = "Farming Simulator 2019",
					Description = "The ultimate farming simulation returns with a complete graphics overhaul and the most complete farming experience ever! Become a modern farmer and develop your farm on two huge American and European environments, filled with exciting new farming activities, crops to harvest and animals to tend to.",
					GamesGenres = GetRandomGenres(1),
					ReleaseDate = new DateTime(2018, 11, 19),
					ImageLink = "https://cdn.verk.net/images/89/2_644443-766x1080.jpg",
					InSale = true
				},
				new()
				{
					Id = 2,
					Name = "The Witcher 3",
					GamesGenres = GetRandomGenres(2),
					Description = "The Witcher 3: Wild Hunt is an action role-playing game with a third-person perspective. Players control Geralt of Rivia, a monster slayer known as a Witcher. Geralt walks, runs, rolls and dodges, and (for the first time in the series) jumps, climbs and swims.",
					ReleaseDate = new DateTime(2015, 05, 18),
					ImageLink = "https://cdn.verk.net/960/images/52/2_560554-2460x4000.jpg",
					InSale = true

				},
				new()
				{
					Id = 3,
					Name = "Destroy All Humans!",
					GamesGenres = GetRandomGenres(3),
					Description = "Destroy All Humans! is an open world action-adventure video game franchise that is designed as a parody of Cold War-era alien invasion films. Destroy All Humans! is available for the PlayStation 2 and Xbox, Destroy All Humans!",
					ReleaseDate = new DateTime(2020, 07, 28),
					ImageLink = "https://images-na.ssl-images-amazon.com/images/I/81akufL4dtL._AC_SY606_.jpg",
					InSale = true
				},
				new()
				{
					Id = 4,
					Name = "Farming Simulator 2022",
					Description = "Farming Simulator 22, realistic and family-friendly as ever, returns on November 22. New features include seasonal cycles, production chains and new crops like grapes and olives. A new build mode and character creator allow for vastly improved customization.",
					ImageLink = "https://cdn2.unrealengine.com/egs-farmingsimulator22preorderbundle-giantssoftware-s3-2560x1440-fe0f2c2e5147.jpg",
					ReleaseDate = new DateTime(2021, 11, 20),
					GamesGenres = GetRandomGenres(4),
					InSale = false
				}
			};

			devsCollection = new()
			{
				new()
				{
					Id = 1,
					Name = "CD Project Red",
					StudioDescription = "Established in 2002, located in Warsaw (HQ), Kraków and Wrocław, Poland, CD PROJEKT RED was born out of raw passion for video games.",
					Image = "https://upload.wikimedia.org/wikipedia/en/thumb/6/68/CD_Projekt_logo.svg/1200px-CD_Projekt_logo.svg.png"
				},
				new()
				{
					Id = 2,
					Name = "GIANTS Software",
					StudioDescription = "Farming Simulator is a farming simulation video game series developed by Giants Software and published by Focus Home Interactive. It has often been described as a farming puzzle game. ... Players are able to farm, breed livestock, grow crops and sell assets created from farming.",
					Image = "https://giants-software.com/img/content/og_base.jpg"
				}
			};
		}

		public bool CreateNewGame(GameModel newGame)
		{
			if(newGame == null)
			{
				return false;
			}
			newGame.Id = gamesCollection.Max(x => x.Id) + 1;
			gamesCollection.Add(newGame);
			return true;
		}

		public bool EditGenre(Genre editedGenre)
		{
			var oldGenre = genreCollection.FirstOrDefault(x => x.Id.Equals(editedGenre.Id));
			if(oldGenre != null)
			{
				oldGenre = editedGenre;
				return true;
			}
			else return false;
		}

		public List<GameModel> GetAllGames()
		{
			return gamesCollection;
		}

		public List<Genre> GetAllGenres()
		{
			return genreCollection;
		}
		public List<GameDeveloper> GetAllDevelopers()
		{
			return devsCollection;
		}
		public GameModel GetGameById(int id)
		{
			return gamesCollection.FirstOrDefault(x =>x.Id.Equals(id));
		}

		public Genre GetGenreById(int id)
		{
			return genreCollection.FirstOrDefault(x => x.Id.Equals(id));
		}

		private List<GamesGenres> GetRandomGenres(int gameId)
		{
			Random rnd = new(DateTime.Now.Millisecond);
			var randomGenreCount = rnd.Next(1, genreCollection.Count);
			List<GamesGenres> gamesGenres = new();
			for(int i = 0; i < randomGenreCount; i++)
			{
				var genreId = rnd.Next(1, genreCollection.Count);
				var res = genreCollection.FirstOrDefault(x => x.Id == genreId);
				if(res != null)
				{
					gamesGenres.Add(
						new GamesGenres
						{	GameId = gameId,
							GenreId = genreId
						}
					);
				}
			}
			return gamesGenres;
		}
	}
}
