namespace Lesson3.V20;

internal class Program
{
    static void Main(string[] args)
    {
        const double magazineCost = 0.2;
        const double newspaperCost = 0.03;

        Console.WriteLine("Do you want magazine or newspaper?");
        var productName = Console.ReadLine();

        Console.WriteLine("deposited amount");
        var deposit = Convert.ToDouble(Console.ReadLine());

        if (productName == "magazine")
        {
            Console.WriteLine($"take change {deposit - magazineCost}");
        }
        else if (productName == "newspaper")
        {
            Console.WriteLine($"take change {deposit - newspaperCost}");
        }
        else
        {
            Console.WriteLine($"\"{productName}\" does not exist");
        }
    }
}