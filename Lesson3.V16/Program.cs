namespace Lesson3.V16;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("total cost");
        var totalCost = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("deposited money");
        var deposit = Convert.ToInt32(Console.ReadLine());

        if (totalCost == deposit) 
        {
            Console.WriteLine("thank you");
        }
        else if (totalCost < deposit) 
        {
            Console.WriteLine($"take change {deposit - totalCost}");
        }
        else 
        {
            Console.WriteLine($"add {totalCost - deposit}");
        }
    }
}