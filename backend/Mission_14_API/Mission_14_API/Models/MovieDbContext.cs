using System;
using Microsoft.EntityFrameworkCore;

//the DB context file for the database and models
namespace Mission_14_API.Models
{
	public class MovieDbContext : DbContext
	{
		public MovieDbContext (DbContextOptions<MovieDbContext> options) :base(options) { }

		public DbSet<MovieData> Movies { get; set; }
	}
}

