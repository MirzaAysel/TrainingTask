using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models
{
    class Hotel
    {
        public string name;
        public Hotel(string name)
        {
            this.name = name;
        }
        public Room[] Rooms = new Room[0];
        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[^1] = room;
        }
        public void MakeReservation(Room roomid)
        {
            
                if (roomid == null)
                {
                    Console.WriteLine("NO ROOM!!!...");
                }
                foreach (Room room in Rooms)
                {
                   
                        if (room.IsAvailable == true)
                            room.IsAvailable = false;
                        else
                        {
                            Console.WriteLine("The room is currently full...");
                        }
                    
                }
            

        }
        
    }
}
