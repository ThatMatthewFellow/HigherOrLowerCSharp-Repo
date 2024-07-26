using System;
// Higher or lower game - ThatMatthewFellow
namespace test{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("\"Here's a higher or lower game\"");
            Random random = new Random();
            // To quit
            int quit = -1;
            // Main loop
            while(quit != 1){
                // Number to base it on
                int rNum = random.Next(1,20);
                // Number to guess
                int gNum = random.Next(1,20);
                // Question
                Console.WriteLine("Will the number be higher or lower than " + Convert.ToString(rNum) + "?");
                // Input
                String guess = "";
                bool hOrLValid = false;
                // Check for if the higher or lower choice is valid
                while(hOrLValid != true){
                    // Input
                    Console.Write("Enter your choice: ");
                    guess = Console.ReadLine();
                    if(guess == "higher" || guess == "lower"){
                        hOrLValid = true;
                    }
                    else{
                        Console.WriteLine("Invalid input!");
                    }
                }
                // Algorithm to see if answer is right
                // For higher
                if(guess == "higher" && gNum > rNum)
                    Console.WriteLine("Correct! The number was: " + Convert.ToString(gNum));
                // For lower
                else if(guess == "lower" && gNum < rNum)
                    Console.WriteLine("Correct! The number was: " + Convert.ToString(gNum));
                // For wrong cases
                else   
                    Console.WriteLine("Incorrect! The number was: " + Convert.ToString(gNum));
                // Try again?
                Console.WriteLine("Would you like to try again? (y/n)");
                String choice = "";
                bool endChoice = false;
                // Check for if the choice is valid
                while(endChoice != true){
                    // Input
                    Console.Write("Enter your choice: ");
                    choice = Console.ReadLine();
                    if(choice == "y" || choice == "n"){
                        endChoice = true;
                    }
                    else{
                        Console.WriteLine("Invalid input!");
                    }
                }
                // Set answer to y just in case
                // End or keep going
                if(choice == "n"){
                    quit = 1;
                    Console.WriteLine("Ending program");
                }
                else{
                    quit = 0;
                }
            }
        }
    }
}