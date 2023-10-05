namespace Lesson3.V15;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("x");
        var x = Convert.ToInt32(Console.ReadLine());

        string? sign;

        if (x == 0)
        {
            sign = "0";
        }
        else if (x > 0) 
        {
            sign = "1";
        }
        else 
        {
            sign = "-1";
        }
        
        Console.WriteLine($"sign(x) = {sign}");
    }
}