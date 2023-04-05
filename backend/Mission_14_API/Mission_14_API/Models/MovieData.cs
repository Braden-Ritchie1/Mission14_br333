using System;
using System.ComponentModel.DataAnnotations;

//model for the database
namespace Mission_14_API.Models
{
	public class MovieData
	{
		[Key]
		public int MovieId { get; set; }

		public string? Title { get; set; }

		public string? Category { get; set; }

		public string? Director { get; set; }

		public int Year { get; set; }

		public string? Rating { get; set; }

		public string? Edited { get; set; }

		public string? LentTo { get; set; }

		public string? Notes { get; set; }
	}
}

