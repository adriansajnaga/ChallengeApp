using ChallengeApp;

Employee employee1 = new Employee("Adrian","Sajnaga");
List<int> employee1Points = [1, 4, 8, 10, 6];
Employee employee2 = new Employee("Michał", "Prorok");
List<int> employee2Points = [5, 3, 10, 10, 5];


foreach(int points in employee1Points)
{
    employee1.AddPoints(points);
}

foreach (int points in employee2Points)
{
    employee2.AddPoints(points);
}


var statistics = employee1.GetStatistics();


Console.WriteLine($"Maksymalna ocena: " + statistics.Max + " | Minimalna ocena: " + statistics.Min + " | Średnia: " + statistics.Avg);
Console.ReadLine();
