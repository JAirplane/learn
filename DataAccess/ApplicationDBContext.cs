using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class ApplicationDBContext: DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
		public DbSet<GameModel> GameModels { get; set; }
        public DbSet<GameDeveloper> GameDevelopers { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
