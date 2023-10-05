namespace Lesson3.V1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("month");
        var month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("day");
        var day = Convert.ToInt32(Console.ReadLine());

        string? poraGoda;

        if ((month >= 3) & (month <= 5))
        {
            poraGoda = "spring";
        }
        else if ((month >= 6) & (month <= 8))
        {
            poraGoda = "summer";
        }
        else if ((month >= 9) & (month <= 11))
        {
            poraGoda = "autumn";
        }
        else if ((month == 12) | (month == 1) | (month == 2)) 
        {
            poraGoda = "winter";
        }
        else
        {
            poraGoda = null;
        }

        if (poraGoda == null)
        {
            throw new ArgumentException();
        }
        else
        {
            Console.WriteLine(poraGoda);
        }

        if (month == 1)
        {
            Console.WriteLine("january");
        }
        else if (month == 2)
        {
            Console.WriteLine("february");
        }
        else if (month == 3)
        {
            Console.WriteLine("march");
        }
        else if (month == 4)
        {
            Console.WriteLine("april");
        }
        else if (month == 5)
        {
            Console.WriteLine("may");
        }
        else if (month == 6)
        {
            Console.WriteLine("june");
        }
        else if (month == 7)
        {
            Console.WriteLine("july");
        }
        else if (month == 8)
        {
            Console.WriteLine("august");
        }
        else if (month == 9)
        {
            Console.WriteLine("september");
        }
        else if (month == 10)
        {
            Console.WriteLine("october");
        }
        else if (month == 11)
        {
            Console.WriteLine("november");
        }
        else if (month == 12)
        {
            Console.WriteLine("december");
        }
        else 
        {
            Console.WriteLine("eror");
        }
    }
}