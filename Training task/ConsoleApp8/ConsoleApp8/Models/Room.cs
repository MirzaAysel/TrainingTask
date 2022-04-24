using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models
{
    
        class Room
        {
            private static int _id;
            public int id { get; }
            public string name;
            public int price;
            public int personCapacity;
            private bool _isAvailable;
       

           public bool IsAvailable
            {
                get
                {
                    if (_isAvailable = true)
                    { }
                    return _isAvailable;
                }
                set
                {
                    if (_isAvailable = false)
                    {
                        Console.WriteLine("False");
                    }

                }
            } 
            public Room()
            {
                ++_id;
                id = _id;

            }
            public Room(string name, int price, int personCapacity) : this()
            {
                this.name = name;
                this.price = price;
                this.personCapacity = personCapacity;
            }
            public virtual void ShowInfo()
            {
                Console.WriteLine($"name {name}, price {price}, personCapacity {personCapacity}");
            }
            public override string ToString()
            {
                return base.ToString() + $"name {name}, price {price}, personCapacity {personCapacity}";

            }
        
    }
}

