using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Übung
{
    internal class RockScissorPaper
    {
        
        public static void RSP()
        {
            Random random = new Random();

            bool playAgain = true;
            String response;
            int playerPoints;
            int computerPoints;
            String player;
            String computer;

            Console.WriteLine("Hello, welcome to my rock paper scissor, the rules are simple.");
            Console.WriteLine("The first to get 3 points wins");
            Console.WriteLine("Got it?");
            Console.ReadKey();
            Console.Clear();

            while (playAgain == true)
            {
                
                playerPoints = 0;
                computerPoints = 0;
                response = "";

                while (playerPoints != 3 && computerPoints != 3)
                {
                    player = "";
                    computer = "";

                    while (player != "rock" && player != "scissor" && player != "paper")
                    {
                        Console.Write("Enter Rock, Paper or Scissor: ");
                        player = Console.ReadLine();
                        player = player.ToLower();
                    }
                    int randomNum = random.Next(1, 4);

                    switch (randomNum)
                    {
                        case 1:
                            computer = "rock";
                            break;
                        case 2:
                            computer = "paper";
                            break;
                        case 3:
                            computer = "scissor";
                            break;
                    }

                    game(player, computer, ref playerPoints, ref computerPoints);
                }
                    if (playerPoints == 3)
                    {
                    Console.Clear();
                    Console.WriteLine($"PlayerPoints: {playerPoints}");
                    Console.WriteLine($"ComputerPoints: {computerPoints}");
                    Console.WriteLine();
                    Console.WriteLine("You won the match!");
                    }
                    else 
                    {
                    Console.Clear();
                    Console.WriteLine($"PlayerPoints: {playerPoints}");
                    Console.WriteLine($"ComputerPoints: {computerPoints}");
                    Console.WriteLine("You lost the match...");
                }
                Console.WriteLine("Would you like to play again? (Y/N)");
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
                        Console.WriteLine("Thanks for playing!");
                    }
                    else { Console.WriteLine("Only use Y or N please!"); }
                }
                
                Console.ReadKey();
            }
        } 




        public static void game(String player, String computer, ref int computerPoints, ref int playerPoints)
        {
            Console.Clear();
            Console.WriteLine($"Player: {player}");
            Console.WriteLine($"Computer: {computer}");

            // Determine round outcome and update points
            if (player == computer)
            {
                Console.WriteLine("It's a draw!");
            }
            else if ((player == "rock" && computer == "scissor") ||
                     (player == "scissor" && computer == "paper") ||
                     (player == "paper" && computer == "rock"))
            {
                Console.WriteLine("You win this round!");
                playerPoints++;
            }
            else
            {
                Console.WriteLine("You lose this round!");
                computerPoints++;
            }

            // Display current points
            Console.WriteLine($"Player Points: {playerPoints}    Computer Points: {computerPoints}");
            Console.ReadKey();
        
        }
    }
}