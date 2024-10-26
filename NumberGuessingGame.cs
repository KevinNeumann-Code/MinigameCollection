using System;

namespace Übung
{
    internal class NumberGuessingGame
    {
        public static void NGG()
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.Clear();
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.Clear();
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                Console.Clear();
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");

                while (response != "y" && response != "n")
                {
                    response = Console.ReadLine();
                    response = response.ToLower();

                    if (response == "y")
                    {
                        playAgain = true;
                    }
                    else if (response == "n")
                    {
                        playAgain = false;
                    }
                    else { Console.WriteLine("Only use y or n please!"); }
                }
            }
                   

            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}