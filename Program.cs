using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Scratch_program_for_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numGenerator = new Random();
                                  
            //intro 
            Console.WriteLine("Hey kid..");
            Console.Write("Response: ");
            Console.ReadLine();
            Console.WriteLine("Wanna play a game with billy? It's called Rock, Paper, Scissors.");
            Console.Write("Response (Y/N): ");

            //play game?
            string playGame = Console.ReadLine();
            if (playGame.ToUpper() == "Y" || playGame.ToUpper() == "YES")
            {
                Console.WriteLine("\nOoooh yeeeaaaahhhh! It's on!!");
                Console.WriteLine("Okay, Are you ready?\n");

                bool keepPlaying = true;
                while (keepPlaying)
                {
                    Console.Write("Rock(1), Paper(2), or Scissors(3)? ");
                    string playerChoice = Console.ReadLine();

                    int gameChoice = numGenerator.Next(1, 4);
                    switch (gameChoice)
                    {
                        case 1:
                            Console.WriteLine("\nBilly chooses Rock");
                            break;
                        case 2:
                            Console.WriteLine("\nBilly chooses Paper");
                            break;
                        default:
                            Console.WriteLine("\nBilly chooses Scissors");
                            break;

                    }
                    if (playerChoice == "1")
                    {
                        Console.WriteLine("You chose Rock\n");
                        if (gameChoice == 1)
                        {
                            Console.WriteLine("Rock and Rock is a stalemate boys.. GO AGANE!");
                        }
                        else if (gameChoice == 2)
                        {
                            Console.WriteLine("Paper wraps Rock... You Lose");
                        }
                        else if (gameChoice == 3)
                        {
                            Console.WriteLine("Rock smashes scissors.. YOU WIN");
                        }
                        else
                        {
                            Console.WriteLine("wat");
                        }
                    }
                    else if (playerChoice == "2")
                    {
                        Console.WriteLine("You chose Paper\n");
                        if (gameChoice == 1)
                        {
                            Console.WriteLine("Paper wraps Rock... You WINNNNN DUDE");
                        }
                        else if (gameChoice == 2)
                        {
                            Console.WriteLine("Paper and paper just sit there... Another Round we go");
                        }
                        else if (gameChoice == 3)
                        {
                            Console.WriteLine("Scissors cuts up paper.. you're a loser");
                        }
                        else
                        {
                            Console.WriteLine("wat");
                        }
                    }
                    else if (playerChoice == "3")
                    {
                        Console.WriteLine("You chose Scissors\n");
                        if (gameChoice == 1)
                        {
                            Console.WriteLine("Rock busts your scissors in half... Maybe next time");
                        }
                        else if (gameChoice == 2)
                        {
                            Console.WriteLine("You're cutting up the enemy into little bits... YOU WIN");
                        }
                        else if (gameChoice == 3)
                        {
                            Console.WriteLine("Scissor me timbers... go again");
                        }
                        else
                        {
                            Console.WriteLine("wat");
                        }
                    }
                    else
                    {
                        int playerError = numGenerator.Next(1, 4);
                        switch (playerError)
                        {
                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("Are you okay? 1, 2, or 3 buddy... REDO\n");
                                break;
                            case 2:
                                Console.WriteLine();
                                Console.WriteLine("...wat...");
                                Console.WriteLine("Do it again - 1, 2, or 3 only!\n");
                                break;
                            default:
                                Console.WriteLine();
                                Console.WriteLine("um, we'll call that a warm up.. only pick 1, 2, or 3\n");
                                break;
                        }
                    }
                    
                    Console.Write("Again(Y/N)? ");
                    string playAgain = Console.ReadLine();
                    Console.WriteLine();
                    
                    if (playAgain.ToUpper() == "Y" || playAgain.ToUpper() =="YES")
                    {

                    }
                    else if (playAgain.ToUpper() == "N" || playAgain.ToUpper() == "NO")
                    {
                        
                        Console.WriteLine("Daaaaang, someone can't take the pressure... seeya...");
                        keepPlaying = false;

                    }
                    else
                    {
                        Console.WriteLine("I'm gonna take that as you wanna play again... Let it RIIIIIDE\n");
                    }
                }

                

            }
            else if (playGame.ToUpper() == "N" || playGame.ToUpper() == "NO")
            {
                Console.WriteLine("\nUh... okay... seeya loser...");
                return;
            }
            else
            {
                Console.WriteLine("uhhh anything other than \"Y\" is a No.. so seeya I guess");
                return;
            }


            
            
            Console.ReadKey();
        }
        
    }

}    
