using System.Text.Json.Serialization;

int results=int.Parse(Console.ReadLine());
if (results < 100) 
{
   
    if (results >= 91)
    {
        Console.WriteLine("A");
    }
    else if (results <= 90 && results >=81)
    {
        Console.WriteLine("B");
    }
    else if (results <= 80 && results >= 71) 
    {
        Console.WriteLine("C");
    }
    else if (results <=70 && results >= 61)
    {
        Console.WriteLine("D");
    }
    else if (results <=60 && results >= 51)
    {
        Console.WriteLine("E");
    }   
    else
    {
        Console.WriteLine("you couldn't pass the exam");
    }

}
else
{
    Console.WriteLine("Wrong input");
}