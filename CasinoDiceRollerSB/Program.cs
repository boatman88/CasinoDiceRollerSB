using System;

namespace CasinoDiceRollerSB
{
    class Program
    {
        static void Main(string[] args)
        {
            //two methods potentially
            //one method to generate dice
            //one to do the dice roll

            //the first number, the minimum is inclusive. The second number is exclusive. So it should be sides +1
            bool goOn = true;

            bool[] rooms = new bool[10];
            while (goOn == true)
            {



            }
            
        }

        public static int DiceRoller(string diceSides)
        {
            
            Random r = new Random();

            Console.WriteLine("How many sides do the dice have?");
            string input = Console.ReadLine();
            int diceSides = int.Parse(input);
            Console.WriteLine();
            int total = 0;
            for (int i = 0; i < diceSides; i++)
            {
                int roll = r.Next(1, diceSides+1);
                total += roll;
                Console.WriteLine(roll);
            }
            Console.WriteLine($"Total: {total}");
            
        }
    }
}
