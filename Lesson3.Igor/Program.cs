namespace Lesson3.Igor;

internal class Program
{
    static void Main(string[] args)
    {
        var bookshelfs = Convert.ToInt32(Console.ReadLine());

        var books = bookshelfs * 3;
        double boards = bookshelfs * 6;

        var wood = Math.Ceiling(boards / 4);
        var leather = books;
        var paper = books * 3;
        var cane = paper;

        var remainder = boards % 4;

        string remainderMsg;

        if (remainder == 0) 
        {
            remainderMsg = "no remainder";
        }
        else
        {
            remainderMsg = remainder.ToString();
        }

        Console.WriteLine($"wood: {wood}\ncane: {cane}\nleather: {leather}\n---remainder---\nboards: {remainderMsg}");







    }
}