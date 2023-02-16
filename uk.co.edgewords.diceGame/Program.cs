namespace uk.co.edgewords.day1consoleapp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] rolls = new int[4];

            string playerInput = "n";

            //loop until 
            while (playerInput != "N")
            {

                Console.WriteLine("");

                for (int i = 0; i < 4; i++)
                {
                    rolls[i] = GenerateRolls();
                }



                //Player Rolls
                Console.WriteLine("Your Roll:");
                Console.WriteLine("You rolled a " + rolls[0] + " and a " + rolls[1]);

                int playerTotal = rolls[0] + rolls[1];
                Console.WriteLine("Total is " + playerTotal);
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                Console.WriteLine("");



                //Computer rolls
                Console.WriteLine("Computer's Roll");
                Console.WriteLine("Computer rolled a " + rolls[2] + " and a " + rolls[3]);
                int cpuTotal = rolls[2] + rolls[3];
                Console.WriteLine("Total is " + cpuTotal);



                //check who wins
                if (playerTotal > cpuTotal)
                {
                    Console.WriteLine("You WON :)");
                }
                else if (playerTotal < cpuTotal)
                {
                    Console.WriteLine("You LOST :(");
                }
                else
                {
                    Console.WriteLine("You DRAW :|");
                }


                Console.WriteLine("Play Again? y or n:");

                //read the input to play again
                playerInput = Console.ReadKey().Key.ToString().ToUpper();

            }



        }


        static int GenerateRolls()
        {
            Random randNum = new Random();
            int roll = randNum.Next(1, 7);

            return roll;
        }


    }

}