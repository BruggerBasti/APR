using System;
namespace Movies.Lib.Models
{
	public class Movie
	{
		public int Id { get; set; }

		public string Title { get; set; } = string.Empty;

		public Movie(int id, string title)
		{
			this.Id = id;
			this.Title = title;
		}
	}
}

