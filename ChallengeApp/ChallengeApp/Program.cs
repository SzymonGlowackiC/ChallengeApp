var name = "Szymon";
var sex = "Mężczyzna";
var age = 17;

if (sex == "Mężczyzna" && age < 18) 
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
