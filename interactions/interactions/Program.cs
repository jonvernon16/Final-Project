using System;

namespace interactions
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an iventory system, you do not have to use arrays I think.
            bool axe = false;
            bool ball = false;
            bool knife = false;
            bool gameOn = true; 

            string userEntry;
            string objectEntry = null;

            while (gameOn == true)
            {
                Console.WriteLine("There is a ball on the ground in front of you, do you wish to pick it up?");
                userEntry = Console.ReadLine();
                if (userEntry == "yes")
                { 
                    Console.WriteLine("You picked up the ball.");
                    ball = true;

                    Console.WriteLine("After you pick up the ball a door seems to appear out of the haze in front of you\nWhat will you do? ");
                    userEntry = Console.ReadLine();

                }
                else if (userEntry == "no")
                {
                    Console.WriteLine("You ignored the ball.");
                }
                

                checkInventory(userEntry, axe, ball, knife);
                inspect(userEntry, objectEntry);
            }
        }
        public static void checkInventory(string userEntry, bool axe, bool ball, bool knife)
        {
            if (userEntry == "check inventory")
            {
                if (axe == true)
                {
                    Console.WriteLine("Axe\n");
                }
                else if (ball == true)
                {
                    Console.WriteLine("Ball\n");
                }
                else if (knife == true)
                {
                    Console.WriteLine("Knife\n");
                }
            }
        }
        public static void inspect(string objectEntry, string userEntry)
        {
            if (userEntry == "inspect " + objectEntry)
            {
                if (objectEntry == "door")
                {
                    Console.WriteLine("You look at the door closer, you see a small round hole on the side of the door.");
                }
            }
        }
           
    }
}
