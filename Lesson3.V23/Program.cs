namespace Lesson3.V23;

internal class Program
{
    static void Main(string[] args)
    {   
        const int bunksCountInRoom = 4;
        
        Console.WriteLine("rooms");
        var roomsCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("women");
        var womenCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("men");
        var menCount = Convert.ToInt32(Console.ReadLine());

        var totalRoomsCountForWomen = Math.Ceiling(Convert.ToDouble(womenCount / bunksCountInRoom));
        var totalRoomsCountForMen = Math.Ceiling(Convert.ToDouble(menCount / bunksCountInRoom));

        var totalQuantityOfRooms = totalRoomsCountForMen + totalRoomsCountForWomen;

        if (totalQuantityOfRooms <= roomsCount)
        {
            Console.WriteLine("Yes, we can");
        }
        else
        {
            Console.WriteLine("No, we can't");
        }
    }
}