using System;
using System.Globalization;
using Movies.Lib.Models;
namespace Movies.Lib.Interfaces
{
	public interface IRepository
	{
		// C       R     U       D
		// Create, Read, Update, Delete
		bool Save();

		List<Movie> Load();

		bool Add(Movie movie);

		bool DeleteById(int id);
	}
}

