using ChallengeApp;
bool employee;
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine($"Witaj w programie do oceny pracownika");
Console.WriteLine($"-------------------------------------");
Console.WriteLine($"");
Console.WriteLine($"");
Console.ResetColor();
Console.WriteLine($"Pracownik fizyczny - wciśnij F");
Console.WriteLine($"Pracownik nadzorujący - wciśnij N");

Worker worker = new Worker();
Supervisor supervisor = new Supervisor();

while (true)
{
    var inputEmployee = Console.ReadLine();
    if (inputEmployee == "F" || inputEmployee == "f") 
    {
        Console.WriteLine("Podaj oceny 0-100 lub A-F");
        employee = true; break; 
    }
    else if (inputEmployee == "N" || inputEmployee == "n") 
    {
        Console.WriteLine("Podaj oceny w systemie szkolnym 1-6");
        employee = false; break; 
    }
    else { Console.WriteLine($"Litera - {inputEmployee} - to nieprawidłowy wybór"); }
}

while (employee)
{
    Console.WriteLine($"Wpisz kolejną ocenę pracownika fizycznego:");
    var input = Console.ReadLine();
    if (input == "q") { break; }
    try
    {
        worker.AddPoints(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

while (!employee)
{
    Console.WriteLine($"Wpisz kolejną ocenę pracownika nadzorującego:");
    var input = Console.ReadLine();
    if (input == "q") { break; }
    try
    {
       supervisor.AddPoints(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

if(employee)
{
    var statistics = worker.GetStatistics();
    Console.WriteLine($"Ilość ocen: {statistics.Count} | Maksymalna ocena: {statistics.Max} | Minimalna ocena: {statistics.Min} | Średnia: {statistics.Avg:N2} | Ocena literowa: {statistics.AvgLetter}");
    Console.ReadLine();
}
if (!employee)
{
    var statistics = supervisor.GetStatistics();
    Console.WriteLine($"Ilość ocen: {statistics.Count} | Maksymalna ocena: {statistics.Max} | Minimalna ocena: {statistics.Min} | Średnia: {statistics.Avg:N2} | Ocena literowa: {statistics.AvgLetter}");
    Console.ReadLine();
}


