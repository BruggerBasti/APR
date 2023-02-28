using ArbeitMitNull;

Auto a = new Auto("blau");
LKW l = new LKW("grün");
Zug z = new();

List<IFahrzeug> fahrzeuge = new();
fahrzeuge.Add(a);
fahrzeuge.Add(l);
fahrzeuge.Add(z);

foreach (IFahrzeug f in fahrzeuge)
{
    f.Fahren();

    if(f is Auto)
    {
        // falls "f" kein Auto ist, ist temp null
        Auto temp = f as Auto;

        Console.WriteLine("Es ist ein Auto");
        Console.WriteLine(temp?.Farbe);
    }
}