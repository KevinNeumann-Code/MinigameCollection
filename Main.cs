using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung
{
    class main
    {
        public static void Main(string[] args)
        {
            String playerDecision;
            bool system = true;
            String response;

            while (system == true) {

                response = "";
                playerDecision = "";

                Console.Clear();
                Console.WriteLine("Which minigame would you like to Play?");
                Console.WriteLine("NumberGuessingGame or Rock Scissor Paper?");
                Console.WriteLine("ngg/rsp");

                while (playerDecision != "ngg" && playerDecision != "rsp") {

                    playerDecision = Console.ReadLine();
                    playerDecision = playerDecision.ToLower();
                    /*switch (playerDecision)
                    {
                        case "ngg":
                            NumberGuessingGame.NGG();
                            break;
                        case "rsp":
                            RockScissorPaper.RSP();
                            break;
                    }
                    Console.WriteLine("Please enter only ngg or rsp!");
                    
                     Does not work as I want it to unfortunately...
                     */
                    if (playerDecision == "ngg")
                    {
                        Console.Clear();
                        NumberGuessingGame.NGG();
                    }
                    else { if (playerDecision == "rsp")
                        {
                            Console.Clear();
                            RockScissorPaper.RSP();
                        }
                    else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter only ngg or rsp!");

                        }                       
                    }
                }

               Console.Clear() ;
                Console.WriteLine("Do you want to play another game? (y/n)");
               

                while (response != "y" &&  response != "n")
                {
                    response = Console.ReadLine();
                    response = response.ToLower();
                    if (response == "y")
                    {
                        system = true;
                    }
                    else
                    {
                        if (response == "n")
                        {
                            system = false;
                        }
                        else
                        {
                            Console.WriteLine("Please enter only y or n!");
                        }
                    }
                }
                
            }
            Console.Clear();
            Console.WriteLine("Thanks for playing my little collection :D");
            Console.ReadKey();
        }
    }
}
