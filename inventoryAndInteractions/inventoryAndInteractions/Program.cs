using System;

namespace inventoryAndInteractions
{
    class Program
    {
        static void Main(string[] args)
        {
            string userEntry;
            string axe;
            int[] inventory = { 0, 1, 2, 3, 4 };
            Console.WriteLine("You see an axe, pick it up?");
            userEntry = Console.ReadLine();

            if (userEntry == "y")
            {
                Console.WriteLine("You picked up the axe.\nPress anything to continue...");
                axe = Convert.ToString(inventory[0]);
            }
            else if (userEntry == "n")
            {
                Console.WriteLine("You ignored the axe");
            }
            Console.ReadKey();
            Console.WriteLine("You see a tree");
        }
        public static void pickUp()
        {

        }
    }
}
