using DefaultNull;

int zahl = default;
Console.WriteLine(zahl); // int = default - Ausgabe: 0

bool demo = default;
Console.WriteLine(demo); // bool = default - Ausgabe: False

Person p = new Person();
Console.WriteLine(p.Firstname);
Console.WriteLine(p.Surname);

Console.WriteLine("Arbeit mit NULL");
Person? p2 = null;

if(p2 != null)
{
    Console.WriteLine(p2.Firstname);
}

Person p3 = null;
Console.WriteLine(p3?.Firstname); // ? => wenn p3 NICHT null ist, wird Firstname ausgegeben

Person standard = new Person();
standard.Firstname = "Max";
standard.Surname = "Muster";

Person p4 = new Person();
p4.Firstname = "Test";

var firstname = (p4 ?? standard).Firstname;
Console.WriteLine("Firstname: {0}", firstname);

var zahl2 = 3;

if (zahl2 < 3) zahl2 = 7;

var zahl3 = 2;

zahl3 = zahl2 < 3 ? 7 : zahl2;

Console.WriteLine("Zahl 3: {0}", zahl3);


Person p5 = new Person("Bastian", "Brugger");
Console.WriteLine(p5.Firstname);
Console.WriteLine(p5.Surname);