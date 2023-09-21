using ChallengeApp;
using System.Runtime.CompilerServices;

Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"Witaj w programie do oceny pracownika");
Console.WriteLine($"-------------------------------------");
Console.WriteLine($"");
Console.WriteLine($"");
Console.ResetColor();

var employee = new EmployeeInFile("Adrian", "Sajnaga");
employee.PointAdded += employee.EmployeePointAdded;


while (true)
{
    Console.WriteLine($"Wpisz kolejną ocenę:");
    var input = Console.ReadLine();
    if (input == "q") { break; }
    try
    {
       employee.AddPoints(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

try
{
    var statistics = employee.GetStatistics();
    Console.WriteLine($"Ilość ocen: {statistics.Count} | Maksymalna ocena: {statistics.Max} | Minimalna ocena: {statistics.Min} | Średnia: {statistics.Avg:N2} | Ocena literowa: {statistics.AvgLetter}");
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadLine();
}




