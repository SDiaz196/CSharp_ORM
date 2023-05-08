// Worked with David and Kirstie

List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

Eruption? firstChileEruption = eruptions.FirstOrDefault(eruption => eruption.Location == "Chile");
Console.WriteLine("=======================");
Console.WriteLine(firstChileEruption);

Eruption? firstHawaiiEruption = eruptions.FirstOrDefault(eruption => eruption.Location == "Hawaiian Is");
Console.WriteLine("=======================");
if (firstHawaiiEruption != null)
{
    Console.WriteLine(firstHawaiiEruption);
}
else
{
    Console.WriteLine("No Hawaiian Is Eruption found.");
}

Eruption? firstGreenlandEruption = eruptions.FirstOrDefault(eruption => eruption.Location == "Greenland");
Console.WriteLine("=======================");
if (firstGreenlandEruption != null)
{
    Console.WriteLine(firstGreenlandEruption);
}
else
{
    Console.WriteLine("No Greenland Eruption Found");
}

List<Eruption> filteredEruptions1 = eruptions.Where(eruption => eruption.Year > 1900 && eruption.Location == "New Zealand").ToList();
Console.WriteLine("=======================");
filteredEruptions1.ForEach(Console.WriteLine);

List<Eruption> filteredEruptions2 = eruptions.Where(eruption => eruption.ElevationInMeters > 2000).ToList();
Console.WriteLine("=======================");
filteredEruptions2.ForEach(Console.WriteLine);

List<Eruption> LEruptions = eruptions.Where(eruption => eruption.Volcano.StartsWith("L")).ToList();
Console.WriteLine("=======================");
LEruptions.ForEach(Console.WriteLine);

int highestElevation = eruptions.Max(eruption => eruption.ElevationInMeters);
Console.WriteLine("=======================");
Console.WriteLine(highestElevation); 

Eruption? highestElevationName = eruptions.FirstOrDefault(eruption => eruption.ElevationInMeters == highestElevation);
Console.WriteLine("=======================");
Console.WriteLine(highestElevationName?.Volcano);

IEnumerable<Eruption> orderEruptions = eruptions.OrderBy(eruption => eruption.Volcano);
Console.WriteLine("=======================");
foreach (Eruption eruption in orderEruptions)
{
    Console.WriteLine(eruption.Volcano);
}

int totalElevation = eruptions.Sum(eruption => eruption.ElevationInMeters);
Console.WriteLine("=======================");
Console.WriteLine(totalElevation);

bool eruptionin2000 = eruptions.Any(eruption => eruption.Year == 2000);
Console.WriteLine("=======================");
Console.WriteLine(eruptionin2000); 

List<Eruption> first3 = eruptions.Where(eruption => eruption.Type == "Stratovolcano").Take(3).ToList();
Console.WriteLine("=======================");
PrintEach(first3);

List<Eruption> filteredEruptions3 = eruptions.OrderBy(eruption => eruption.Volcano).Where(eruption => eruption.Year < 1000).ToList();
Console.WriteLine("=======================");
filteredEruptions3.ForEach(Console.WriteLine); 

List<string> filteredEruption4 = eruptions.Where(eruption => eruption.Year < 1000 ).OrderBy(eruption => eruption.Volcano).Select(eruption => eruption.Volcano).ToList();
Console.WriteLine("=======================");
filteredEruption4.ForEach(Console.WriteLine);


// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}




