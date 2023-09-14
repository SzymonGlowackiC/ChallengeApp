using ChallengeApp;

var employee = new Employee("Adam", "Kamilzelich");
employee.AddGrade("Adam");
employee.AddGrade("2");
employee.AddGrade(5);
employee.AddGrade(600);
employee.AddGrade(6);
var statistics = employee.GetStatistics();


Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Average:N2}");
