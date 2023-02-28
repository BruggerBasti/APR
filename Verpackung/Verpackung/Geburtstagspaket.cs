using System;
namespace Verpackung
{
    public class Geburtstagspaket : Paket
    {
        public double Höhe { get; set; }

        public Geburtstagspaket(double länge, double breite, double höhe, double gewicht, Person p) : base(länge, breite, gewicht, p)
        {
            this.Höhe = höhe;
        }

        public override void Verpacken()
        {
            base.Verpacken();
            Console.WriteLine($"Das Paket mit der Höhe {Höhe}cm wird mit einer Schleife verpackt.");
        }
    }
}