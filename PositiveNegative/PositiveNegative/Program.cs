using System.Text.Json.Serialization;

int input = int.Parse(Console.ReadLine());
if (input != 0)
{
    if (input < 0)
    {
        Console.WriteLine("your input is Negative");
    }
    else
    {
        Console.WriteLine("your input is Positive");
    }
}
else
{
    Console.WriteLine("Your input is Zero");
}