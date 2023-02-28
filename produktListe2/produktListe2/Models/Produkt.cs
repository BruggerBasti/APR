using System;
namespace produktListe2.Models
{
    public class Produkt
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Titel { get; set; } = string.Empty;

        public string Bild { get; set; } = string.Empty;

        public string Beschreibung { get; set; }
    }
}

