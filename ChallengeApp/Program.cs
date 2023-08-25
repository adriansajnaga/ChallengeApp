using ChallengeApp;

Employee employee1 = new Employee("Adrian","Sajnaga",36);
List<int> employee1Points = [1, 4, 8, 10, 6];
Employee employee2 = new Employee("Michał", "Prorok", 41);
List<int> employee2Points = [5, 3, 10, 10, 5];
Employee employee3 = new Employee("Przemek", "Wolański", 27);
List<int> employee3Points = [7, 1, 2, 2, 3];
List<Employee> employees = [employee1, employee2, employee3];

var maxPoints = 0;
Employee winner = null;

foreach(int points in employee1Points)
{
    employee1.AddPoints(points);
}

foreach (int points in employee2Points)
{
    employee2.AddPoints(points);
}

foreach (int points in employee3Points)
{
    employee3.AddPoints(points);
}

foreach (var employee in employees)
{
        if (employee.SumOfPoints>maxPoints)
        {
           maxPoints = employee.SumOfPoints;
           winner = employee;
        }
}

Console.WriteLine($"The best employee of this month is: " + winner.Name + " " +winner.Surname);
Console.WriteLine("He is " + winner.Age + " and has earned a total of " + maxPoints + " points!");
