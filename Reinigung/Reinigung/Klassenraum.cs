using System;
namespace Reinigung
{
    public class Klassenraum : IRaum, IReinigung
    {
        public string Bezeichnung { get; set; }

        public double Größe { get; set; }

        public void Reinigung()
        {
            Console.WriteLine($"Der {Bezeichnung} mit {Größe}m2 wird gereinigt.");
        }

        public Klassenraum(string bezeichnung, double größe)
        {
            this.Bezeichnung = bezeichnung;
            this.Größe = größe;
        }
    }
}

