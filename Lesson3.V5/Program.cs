namespace Lesson3.V5;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("THE FIRST number");
        var theFirst = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("THE SECOND number");
        var theSecond = Convert.ToDouble(Console.ReadLine());

        if (theFirst == theSecond)
        {
            Console.WriteLine("the numbers are equal");
        }
        else if ((theFirst > 0) && (theSecond > 0))
        {
            Console.WriteLine("the product of numbers is" + theFirst * theSecond);
        }
        else if ((theFirst < 0) && (theSecond < 0))
        {
            Console.WriteLine($"the sum is {theFirst + theSecond}");
        }
        else 
        {
            Console.WriteLine("doesn't meet any condition");
        }
    }
}