using System;
using ConsoleApp8.Models;

namespace ConsoleApp8
{
                class Program
        {
            static void Main(string[] args)
            {
                Room rooms = new Room("AA1", 100, 1);
                Console.WriteLine(rooms.id);
                Room room2 = new Room("BB1", 300, 2);
                Console.WriteLine(room2.id);

                Hotel hotel = new Hotel("Hilton");
                hotel.AddRoom(rooms);
                hotel.AddRoom(room2);
                Console.WriteLine(hotel.name);
                Console.WriteLine(hotel.Rooms);

            
        }
    }
}
    
