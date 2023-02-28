using System;
namespace ArbeitMitNull
{
	public class LKW : IFahrzeug
	{
		public string Farbe { get; set; }

		public void Fahren()
		{
			Console.WriteLine("Brumm Brumm aber LKW");
		}

		public LKW(string farbe)
		{
			this.Farbe = farbe;
		}
	}
}

