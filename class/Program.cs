using System;
using System.Collections.Generic;

namespace Class
{
    class Room
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Description { get; set; }

        public Room(int x, int y, string description)
        {
            X = x;
            Y = y;
            Description = description;
        }

        internal string GetRoomLocationKey()
        {
            return $"{X},{Y}";
        }
    }

    class Program
    {
        static Dictionary<string, Room> rooms = new Dictionary<string, Room>();

        static void Main(string[] args)
        {
            // Add start room
            rooms["0,0"] = new Room(0, 0, "You are in the start room.");

            // Add more rooms
            rooms["1,0"] = new Room(1, 0, "You are in the east room.");
            rooms["0,1"] = new Room(0, 1, "You are in the north room.");
            rooms["-1,0"] = new Room(-1, 0, "You are in the west room.");

            // Show rooms
            ShowRoom(0, 0);
            ShowRoom(1, 0);
            ShowRoom(0, 1);
            ShowRoom(-1, 0);

            // Try non-existing room
            ShowRoom(2, 2);
        }

        private static void ShowRoom(int x, int y)
        {
            string key = $"{x},{y}";
            if (rooms.ContainsKey(key))
            {
                Room room = rooms[key];
                Console.WriteLine(room.Description);
            }
            else
            {
                Console.WriteLine("The room does not exist.");
            }
        }
    }
}
