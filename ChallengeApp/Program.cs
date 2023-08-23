string name = "Ewa";
bool isMan = false;          
uint age = 40;

if(isMan)       
{
    if(age>=18)
    {
        Console.WriteLine($"Pełnoletni mężczyzna o imieniu {name}");
    }
    else
    {
        Console.WriteLine("Niepełnoletni mężczyzna");       //Komunikat (1)
    }
}
else         
{
    if (age == 33 && name=="Ewa")
    {
        Console.WriteLine("Ewa, lat 33");                   //Komunikat (2)
    }
    else if (age <30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");        //Kumunikat (3)
    }
    else
    {
        Console.WriteLine($"Kobieta o imieniu {name} w wieku {age} lat");
    }
}
Console.ReadKey();
