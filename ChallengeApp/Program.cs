using ChallengeApp;

Employee employee1 = new Employee("Adrian","Sajnaga");
List<int> employee1Points = [1, 4, -8, 101, 6];

foreach(int points in employee1Points)
{
    employee1.AddPoints(points);
}

employee1.AddPoints("100");
employee1.AddPoints("Test");
Console.WriteLine("");

var statistics = employee1.GetStatisticsWithForEach();
Console.WriteLine("Pętla foreach");
Console.WriteLine($"Maksymalna ocena: {statistics.Max} | Minimalna ocena: {statistics.Min} | Średnia: {statistics.Avg:N2}");
Console.WriteLine("");

var statistics2 = employee1.GetStatisticsWithDoWhile();
Console.WriteLine("Pętla do while");
Console.WriteLine($"Maksymalna ocena: {statistics.Max} | Minimalna ocena: {statistics.Min} | Średnia: {statistics.Avg:N2}");
Console.WriteLine("");

var statistics3 = employee1.GetStatisticsWithWhile();
Console.WriteLine("Pętla while");
Console.WriteLine($"Maksymalna ocena: {statistics.Max} | Minimalna ocena: {statistics.Min} | Średnia: {statistics.Avg:N2}");
Console.WriteLine("");

var statistics4 = employee1.GetStatisticsWithFor();
Console.WriteLine("Pętla for");
Console.WriteLine($"Maksymalna ocena: {statistics.Max} | Minimalna ocena: {statistics.Min} | Średnia: { statistics.Avg:N2}");
Console.ReadLine();
