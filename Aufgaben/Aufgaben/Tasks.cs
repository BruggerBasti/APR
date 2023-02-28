using System;
namespace Aufgaben
{
	public class Tasks
	{
		public Tasks(string titel, string notiz, DateTime datum, Priority prioritaet)
		{
			Titel = titel;
			Notiz = notiz;
			Datum = datum;
			Prioritaet = prioritaet;
		}

		public string Titel { get; set; }

		public string Notiz { get; set; }

		public DateTime Datum { get; set; }

		public Priority Prioritaet { get; set; } = Priority.Low;

        public override string ToString()
        {
            return this.Titel;
        }
    }
}

