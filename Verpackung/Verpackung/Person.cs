using System;
namespace Verpackung
{
	public class Person : IVersand
	{
		public string Vorname { get; set; }

		public string Nachname { get; set; }

		public Person(string vorname, string nachname)
		{
            Vorname = vorname;
            Nachname = nachname;
		}

		public void Versenden(IPaket p)
		{
			Console.WriteLine($"Das Paket wird an {p?.Empfänger?.Nachname} versendet.");
		}
 	}
}

