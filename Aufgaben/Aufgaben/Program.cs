using Aufgaben;

List<Tasks> tasks = new()
{
    new Tasks("APR Lernen", "Schnittstellen", DateTime.Now, Priority.High),
    new Tasks("Mathe Hausübung", "S41, 42/Ü 5.01, 5.02", DateTime.Now.AddDays(5).AddHours(2).AddMinutes(32), Priority.Low),
    new Tasks("BW Schularbeit", "Marketing", DateTime.Now.AddDays(40), Priority.Middle),
};

var tasks2 = from Task in tasks
             select Task;

foreach (Tasks t in tasks)
{
    Console.WriteLine($"Titel: {t}");
    Console.WriteLine($"Notiz: {t.Notiz}");
    Console.WriteLine($"Datum: {t.Datum}");
    Console.WriteLine($"Priorität: {t.Prioritaet}");
    Console.WriteLine();
}