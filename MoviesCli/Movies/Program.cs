using Movies;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Xml.Linq;

XElement rootElement = XElement.Load("movies.xml");

string filmName;
string filmTyp;
double filmLänge;
double filmPreis;

int filmCount = 0;

do {
	Console.WriteLine("Welchen Film möchtest du hinzufügen? ");
	filmName = Console.ReadLine();

	if (filmName != "") {
		filmCount++;

		Console.WriteLine("Welcher Typ war es? ");
		Console.WriteLine("1 - DVD, 2 - Blueray, 3 - Streaming");
		int filmTypZahl = Convert.ToInt32(Console.ReadLine());
		filmTyp = "";

		if (filmTypZahl == 1) {
			filmTyp = "DVD";
		} else if (filmTypZahl == 2) {
			filmTyp = "Blueray";
		} else if (filmTypZahl == 3) {
			filmTyp = "Streaming";
		} else {
			Console.WriteLine("Das ist keine Antwortmöglichkeit!");
		}

		Console.WriteLine("Wie lange hat der Film gedauert? ");

		filmLänge = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Wie viel hat der Film gekostet? ");
		filmPreis = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Die Daten wurden eingegeben!");

		var movieItem = new XElement("movie");

		movieItem.Add(new XAttribute("name", filmName));
		movieItem.Add(new XAttribute("typ", filmTyp));
		movieItem.Add(new XAttribute("dauer", filmLänge));
		movieItem.Add(new XAttribute("preis", filmPreis));

		rootElement.Add(movieItem);
	}

} while (filmName != "");

if (filmCount == 0) {
	Console.WriteLine("Kein Film wurde gespeichert.");
} else if (filmCount == 1) {
	Console.WriteLine("Ein Film wurde gespeichert.");
	rootElement.Save("movies.xml");
} else if(filmCount > 1) {
	Console.WriteLine("Mehrere Filme wurden gespeichert.");
	rootElement.Save("movies.xml");
}