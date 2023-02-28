// data source
List<int> numbers = new() { 2, 4, 5, 6, 7, 10, 12 };

// query
var nums = from num in numbers
           select num;

numbers.Add(11);

// (microsoft) access
foreach (var item in nums) // hier wird die Abfrage "ausgewertet"
{
    Console.WriteLine($"1: Item ist: {item}");
}

Console.WriteLine();

var nums2 = from num in numbers
            where num % 2 == 0
            select num;

foreach (var item in nums2) // hier wird die Abfrage "ausgewertet"
{
    Console.WriteLine($"2: Item ist: {item}");
}

Console.WriteLine();

var nums3 = from num in numbers
           where num % 2 == 0
           where num > 3
           where num < 12
           select num;

foreach (var item in nums3) // hier wird die Abfrage "ausgewertet"
{
    Console.WriteLine($"3: Item ist: {item}");
}

Console.WriteLine();

var nums4 = from num in numbers
            where num % 2 == 0
            where num > 3
            where num < 12
            orderby num
            select num;

foreach (var item in nums4) // hier wird die Abfrage "ausgewertet"
{
    Console.WriteLine($"4: Item ist: {item}");
}