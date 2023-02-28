var name = "Szymon";
var sex = "Mężczyzna";
var age = 21;

if (sex == "Mężczyzna") 
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else if (age > 18)
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }
}