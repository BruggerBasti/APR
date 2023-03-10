using Movies.Lib.Interfaces;
using Movies.Lib.Models;
using Movies.Lib.Services;

IRepository repository = new MemoryRepository();

Movie m1 = new Movie(1, "Star Wars: Das Erwachen der Macht");
Movie m2 = new Movie(2, "Harry Potter und der Stein der Weisen");
Movie m3 = new Movie(5, "Titanic");
Movie m4 = new Movie(7, "Star Wars: Das Imperium schlägt zurück");

// zum Repository/Liste hinzufügen
repository.Add(m1);
repository.Add(m2);
repository.Add(m3);
repository.Add(m4);

// Alle Movies vom Repository laden/ausgeben
List<Movie> movies = repository.Load();

foreach (var item in movies) {
	Console.WriteLine(item.Title);
}