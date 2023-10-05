namespace Lesson3.V2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("mark");
        var mark = Convert.ToInt32(Console.ReadLine());

        if ((mark >= 3) && (mark <= 5))
        {
            Console.WriteLine("exam passed");
        }
        else if ((mark >=0) && (mark <= 2))
        {
            Console.WriteLine("try again");
        }
        else 
        {
            Console.WriteLine("exam not passed");
        } 
    }
}