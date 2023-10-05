namespace Lesson3.V4;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("day of the week number");
        var numberOfDay = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("month");
        var month = Convert.ToInt32(Console.ReadLine());

        string? day;

        if (numberOfDay == 1)
        {
            day = "monday";
        }
        else if (numberOfDay == 2)
        {
            day = "tuesday";
        }
        else if (numberOfDay == 3)
        {
            day = "wednesday";
        }
        else if (numberOfDay == 4)
        {
            day = "thursday";
        }
        else if (numberOfDay == 5)
        {
            day = "friday";
        }
        else if (numberOfDay == 6)
        {
            day = "saturday";
        }
        else if (numberOfDay == 7)
        {
            day = "sunday";
        }
        else
        { 
            day = null;
        }

        if (day == null)
        {
            throw new ArgumentException();
        }
        else 
        {
            Console.WriteLine(day);
        }

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
    }
}