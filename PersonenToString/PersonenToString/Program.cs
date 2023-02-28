using PersonenToString;

IPerson p1 = new UmbenennenPerson("Daniela", "Huber");

if (p1 is UmbenennenPerson)
{
    (p1 as UmbenennenPerson).Umbenennen("Herta");
}

Console.WriteLine($"Vorname: {p1.Vorname}");
Console.WriteLine($"Name: {p1}");

// Setzen des Namens ist nicht erlaubt, da "private set"
// p1.Vorname = "Herta";