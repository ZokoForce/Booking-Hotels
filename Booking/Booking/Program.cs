
using Booking;
List<Room> rooms = new List<Room>();

while (true)
{
    int command = int.Parse(Console.ReadLine());

    if (command == 1)
    {
        int id = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        int floor = int.Parse(Console.ReadLine());
        int price = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());
        string status = Console.ReadLine();
        string description = Console.ReadLine();
        Room room = new Room(id, type, floor, price, capacity, status, description);
        rooms.Add(room);
        Console.WriteLine("Room added successfully.");


    }
    else if (command == 2)
    {
        foreach (Room room in rooms)
        {
            room.GETInfo();
        }
    }
}