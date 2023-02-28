using System;
namespace Reinigung
{
    public class Büroraum : IRaum, IReinigung
    {
        public string Bezeichnung { get; set; }

        public double Größe { get; set; }

        public void Reinigung()
        {
            Console.WriteLine($"Der {Bezeichnung} mit {Größe}m2 wird gestaubsaugt.");
        }

        public Büroraum(string bezeichnung, double größe)
        {
            this.Bezeichnung = bezeichnung;
            this.Größe = größe;
        }
    }
}

