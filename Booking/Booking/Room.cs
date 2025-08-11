using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    internal class Room
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Floor { get; set; }
        public int Price { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public Room(int id, string type, int floor, int price, int capacity, string status, string description)
        {
            ID = id;
            Type = type;
            Floor = floor;
            Price = price;
            Capacity = capacity;
            Status = status;
            Description = description;
        }

        public void GETInfo()
        {
            Console.WriteLine($"Room ID: {ID}, Tipe: {Type}, Price: {Price}");
        }
    }
}
