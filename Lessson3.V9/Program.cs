using System.ComponentModel.Design;

namespace Lessson3.V9;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("side length 1");
        var side1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("side length 2");
        var side2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("side length 3");
        var side3 = Convert.ToInt32(Console.ReadLine());

        if ((side1 == side2) && (side2 == side3))
        {
            Console.WriteLine("equilateral triangle");
        }
        else if ((side1 == side3) || (side1 == side2) || (side2 == side3))
        {
            Console.WriteLine("isosceles triangle");
        }
        else 
        {
            Console.WriteLine("does not belong to any type");
        }
    }
}