﻿using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników ");
Console.WriteLine("=======================================");
Console.WriteLine();


var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:  ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched{e.Message}");
    } 

}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: { statistics.Average}");
Console.WriteLine($"AVG Letter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");