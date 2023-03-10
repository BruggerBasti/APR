using System;
using System.Threading.Channels;
using Movies.Lib.Interfaces;
using Movies.Lib.Models;

namespace Movies.Lib.Services
{
	public class MemoryRepository : IRepository
	{
		List<Movie> _movies = new List<Movie>();

		public bool Add(Movie movie)
		{
			_movies.Add(movie);
			return true;
		}

		public bool DeleteById(int id)
		{
			int elem = _movies.RemoveAll(x => x.Id == id);
			return elem > 0;

			/*
			var item = (from movie in this._movies
						where movie.Id == id
						select movie).First();

			return this._movies.Remove(item);
			*/
		}

		public List<Movie> Load()
		{
			return _movies;
		}

		public bool Save()
		{
			return true;
		}
	}
}

