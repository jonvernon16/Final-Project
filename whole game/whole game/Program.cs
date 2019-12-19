using System;

namespace whole_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] map = { 0, 1, 2, 3 };

            string userEntry;
            string north;
            string east;
            string south;
            string west;

            bool again = true;
            Console.WriteLine("Spooky Forest\nPress any key to start.");
            Console.ReadKey(true);
            //Console.ReadKey waits for an input
            Console.WriteLine("You awake in an empty clearing in a forest. \n"
                + " There are 3 possible paths, North, East, or West.\n Which do you choose?\n");
            userEntry = Console.ReadLine();
            while (again)
            {
                string readKey;
                readKey = Convert.ToString(Console.ReadKey(true));
                if (readKey == "w")
                {
                    Console.WriteLine("Forward");
                }

                
            }

        }

    }
}
