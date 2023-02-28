using System;
namespace ArbeitMitNull
{
    public class Zug : IFahrzeug
    {
        public void Fahren()
        {
            Console.WriteLine("Brumm Brumm aber Zug");
        }
    }
}

