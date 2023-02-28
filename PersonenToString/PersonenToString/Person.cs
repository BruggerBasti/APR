using System;
namespace PersonenToString
{
	public class Person : IPerson
	{
        public Person(string vorname, string nachname)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
        }

        public string Vorname { get; protected set; }

		public string Nachname { get; private set; }

		public override string ToString()
		{
			return String.Format("{0} {1}", this.Vorname, this.Nachname);
		}
	}
}

