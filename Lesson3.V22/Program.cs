namespace Lesson3.V22;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("x");
        var x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("y");
        var y = Convert.ToInt32(Console.ReadLine());

        string? quarter;

        if ((x > 0) && (y > 0))
        {
            quarter = "1";
        }
        else if ((x < 0) && (y > 0))
        {
            quarter = "2";
        }
        else if ((x < 0) && (y < 0))
        {
            quarter = "3";
        }
        else if ((x > 0) && (y < 0))
        {
            quarter = "4";
        }
        else
        {
            quarter = null;
        }

        if (quarter == null)
        {
            throw new ArgumentException();
        }
        else
        {
            Console.WriteLine(quarter);
        }
    }
}