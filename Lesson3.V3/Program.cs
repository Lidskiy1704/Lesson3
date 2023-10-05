namespace Lesson3.V3;

internal class Program
{
    static void Main(string[] args)
    {
        var number = Convert.ToInt64(Console.ReadLine());
        var condition = (number >= -8 && number < 4) || number > 9;

        if (!condition)
        {
            number /= 2;
        }

        Console.WriteLine(number);
    }
}