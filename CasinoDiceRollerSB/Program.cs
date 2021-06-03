using System;

namespace RandomNumberGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop it
            do
            {
                //1) get user input
                int numberOfSides = GetUserInputAsInt();

                //2) roll two dice with a number of sides
                //here we declare int[] dice and assign it to the results of the RollTwoDice method which
                //takes numberOfSides as an argument

                //Here we declare an int[] called dice, and assign it to the result of the return of RollTwoDice
                int[] dice = RollTwoDice(numberOfSides);

                //3) output the results with the special conditions (craps and shit)(big dumb if block)
                PrintResults(dice, numberOfSides);
            }
            while (GetUserContinue() == true);

        }

        //This is another reusable method that can be used in the future*********
        public static bool GetUserContinue()
        {
            Console.WriteLine("Would you like to roll the dice again? y/n");
            string input = Console.ReadLine();
            if (input == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //                              
        public static void PrintResults(int[] dice, int sides)
        {
            //this Console.Writeline is how the program delivers the outcomes to the user depending on the following if statements:
            Console.WriteLine($"Roll One: {dice[0]}\tRoll Two: {dice[1]}\tTotal: {dice[0] + dice[1]}");
            if (sides == 6)
            {
                //Snake Eyes: Two 1s
                if (dice[0] == 1 && dice[1] == 1)
                {
                    Console.WriteLine("Snake Eyes!");
                }
                //Ace Deuce: A 1 and 2
                //dice1        dice2               dice2        dice1
                if ((dice[0] == 1 && dice[1] == 2) || (dice[0] == 2 && dice[1] == 1))
                {
                    Console.WriteLine("Ace Deuce");
                }
                // Box Cars: Two 6s
                if (dice[0] == 6 && dice[1] == 6)
                {
                    Console.WriteLine("Box Cars");
                }
                //Win: A total of 7 or 11
                if ((dice[0] + dice[1] == 7 || dice[0] + dice[1] == 11))
                {
                    Console.WriteLine("Win");
                }
                //Craps: A total of 2, 3, or 12(will also generate another message!)
                //What does this mean in human words?: if any of these 3 outcomes, then write "win"
                if ((dice[0] + dice[1] == 2) || (dice[0] + dice[1] == 3) || (dice[0] + dice[1] == 12))
                {
                    Console.WriteLine("Win");
                }

                // Ask the user if he/she wants to roll dice again 
                // See GetUserContinue Method
            }
        }

        //fun fact:
        //when you call a method, you call it and give it arguments
        //but, when you declare a method, you declare it and assign it parameters


        //RollTwoDice takes in a number of sides
        public static int[] RollTwoDice(int sides)
        {
            //create a new random object
            Random random = new Random();
            //declare it/set up our return values to put our results in
            int[] diceRolls = new int[2];

            //do some stuff to it
            //here we have two ints to simulate our dice rolls using random.Next between 1 and the number of sides
            //+1 is included because random.Next is exclusive in the top range
            int roll1 = random.Next(1, sides + 1);
            int roll2 = random.Next(1, sides + 1);

            //reassigning dice rolls equal to the values of the random numbers we just generated above
            diceRolls[0] = roll1;
            diceRolls[1] = roll2;

            //we declared it, we did some stuff to it, and now we're returning it
            //Lastly, return simply tells our code to return tot he next step in the program aka return to the top/ i.e. exit the method.
            return diceRolls;
        }

        //useful get userinput method to be reused in future projects*******
        public static int GetUserInputAsInt()
        {
            int result = 0;
            bool goOn = true;
            while (goOn)
            {
                //promt user for input
                // out assigns a value to result if the Parse succeeds
                // the method takes in a string-in this case Console.Readline(),
                // if it successfully parses the value it will assign the result to whatever you have following the out keyword
                // i.e. "7" it should succeed and result = 7
                Console.WriteLine("How many sides do the dice have?");
                bool userInput = int.TryParse(Console.ReadLine(), out result);

                //this becomes true when the user successfully enters an input that passes the .TryParse method
                if (userInput == true)
                {
                    goOn = false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            return result;
        }
    }
}
