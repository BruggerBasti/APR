using System;
namespace DefaultNull
{
	public class Person
	{
		public string Firstname { get; set; } = "";

		// mit ? wird ein NULL-Wert erlaubt
		public string? Surname { get; set; }

		public Person(string vorname, string nachname)
		{
			Firstname = vorname;
			Surname = nachname;
		}

		public Person()
		{

		}
	}
}

