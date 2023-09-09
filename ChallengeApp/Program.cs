using ChallengeApp;
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"Witaj w programie do oceny pracownika");
Console.WriteLine($"-------------------------------------");
Console.WriteLine($"");
Console.WriteLine($"");
Console.ResetColor();
Employee employee = new Employee("Adrian", "Sajnaga", 36, "M", "Junior .NET Developer");

while (true)
{
    Console.WriteLine($"Wpisz kolejną ocenę pracownika:");
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

var statistics = employee.GetStatistics();
Console.WriteLine($"Ilość ocen: {statistics.Count} | Maksymalna ocena: {statistics.Max} | Minimalna ocena: {statistics.Min} | Średnia: {statistics.Avg:N2} | Ocena literowa: {statistics.AvgLetter}");
Console.ReadLine();
