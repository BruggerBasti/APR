using System;
namespace ArbeitMitNull
{
	public class Auto : IFahrzeug
	{
		public string Farbe { get; set; } = string.Empty;

		public void Fahren()
		{
			Console.WriteLine("Brumm Brumm");
		}

		public Auto(string farbe)
		{
			this.Farbe = farbe;
		}
	}
}

