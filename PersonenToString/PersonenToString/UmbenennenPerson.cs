using System;
namespace PersonenToString
{
    public class UmbenennenPerson : Person
    {
        public UmbenennenPerson(string vorname, string nachname) : base(vorname, nachname)
        {
        }

        public void Umbenennen(string vorname)
        {
            this.Vorname = vorname;
        }
    }
}

