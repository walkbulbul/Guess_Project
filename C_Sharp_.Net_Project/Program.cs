using System;

// Name Space 
namespace C_Sharp_.Net_Project
{
    // Main Class
    class Program
    {
        // Method
        static void Main(string[] args)
        {
            // Run this function to get info 
            GetAppInfo();

            // Ask user name and salute
            SaluteUser(); 

            while (true)
            {
                // Set Correct Number
                // var correctNumber = 7;

                // Create a New Random Number
                Random random = new Random();

                // Set Correct Number
                var correctNumber = random.Next(1, 10);

                // Set Guess Var 
                var guess = 0;

                // Ask User for Number
                Console.WriteLine("Please guess a number between 1 to 10 ");

                // When Answer is Wrong
                while (guess != correctNumber)
                {
                    // Get User Input
                    string inputNumber = Console.ReadLine();

                    // Make sure its a number !
                    if (!int.TryParse(inputNumber, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;
                    }

                    // Cast to in and put in guess
                    guess = Int32.Parse(inputNumber);

                    // Match Guess to Correct Number
                    if (guess != correctNumber)
                    {
                        // Set error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }

                }
                

                // Set Success message
                PrintColorMessage(ConsoleColor.Yellow, "You guessed it. Congrulations.");

                // Play Again!
                Console.WriteLine("Do you want to play again! [ Y / N ]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }
        // Get and display info 
        static void GetAppInfo()
        {
            string appName = "Guess Number";
            string appVersion = "1.0.0.1";
            string appCreator = "Volkan Bulbul";

            // Change color of text (Red)
            Console.ForegroundColor = ConsoleColor.Green;

            // App Info 
            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appCreator);

            // Reset Text Color
            Console.ResetColor();
        }
        static void SaluteUser()

        // Ask user name and salute 
        {
            // Name Information 
            Console.WriteLine("What is your name !");

            // User Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, enjoy...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change color of text (Yellow)
            Console.ForegroundColor = color;

            // Tell User its not number 
            Console.WriteLine(message);

            // Reset Text Color
            Console.ResetColor();

        }

        
    }
}
