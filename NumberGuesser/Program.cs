using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetUser();

            while (true)
            {
                

                // Set correct number
                //int correctNumber = 7;
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    string guessInput = Console.ReadLine();

                    // MAke sure guess is a number
                    if (!int.TryParse(guessInput, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number", ConsoleColor.Cyan);
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = int.Parse(guessInput);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Incorrect number, please try again", ConsoleColor.Cyan);
                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Green, "You are correct", ConsoleColor.White);

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }

            }

        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Afzal";

            Console.ForegroundColor = ConsoleColor.Cyan;
            // Console.BackgroundColor = ConsoleColor.White;

            // Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");
        }

        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string input = Console.ReadLine();

            Console.WriteLine($"Hello {input}, let's play a game");
        }

        static void PrintColorMessage(ConsoleColor initColor, string message, ConsoleColor finalColor)
        {
            Console.ForegroundColor = initColor;
            Console.WriteLine(message);
            Console.ForegroundColor = finalColor;
        }
    }
}
