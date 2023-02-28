using System;
namespace Verpackung
{
	public class Paket : IPaket
	{
		public double Länge { get; set; }

		public double Breite { get; set; }

		public double Gewicht { get; set; }

		public Person Empfänger { get; set; }

        public Paket(double länge, double breite, double gewicht, Person p)
		{
			Länge = länge;
			Breite = breite;
			Gewicht = gewicht;
			this.Empfänger = p;
		}

        public virtual void Verpacken()
        {
			// throw new NotImplementedException();
			Console.WriteLine($"Das Paket mit der Länge {Länge}cm verpackt.");
        }
    }
}

