using SpruchLib;

Spruch s = new Spruch();

s.AddSpruch("Lorem"); // 0
s.AddSpruch("ipsum"); // 1
s.AddSpruch("dolor"); // 2

try
{
    Console.WriteLine(s.NextSpruch()); // Lorem
    Console.WriteLine(s.NextSpruch()); // ipsum
    Console.WriteLine(s.NextSpruch()); // dolor
    Console.WriteLine(s.NextSpruch()); // Lorem
    Console.WriteLine(s.NextSpruch()); // ipsum
    Console.WriteLine(s.NextSpruch()); // dolor
}
catch (SpruchException e)
{
    Console.WriteLine("Die Sprüche konnten nicht ausgegeben werden:");
    Console.WriteLine(e.Message);
}