using ChallengeApp;

Employee employee1 = new Employee("Adrian","Sajnaga");
List<int> employee1Points = [1, 4, -8, 101, 6];

foreach(int points in employee1Points)
{
    employee1.AddPoints(points);
}

employee1.AddPoints("100");
employee1.AddPoints("Test");

var statistics = employee1.GetStatistics();


Console.WriteLine($"Maksymalna ocena: {statistics.Max} | Minimalna ocena: {statistics.Min} | Średnia: { statistics.Avg:N2}");
Console.ReadLine();
