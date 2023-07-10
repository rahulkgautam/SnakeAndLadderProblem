using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderProblem
{
    class SnakeAndLadder
    {
        public static void PlaySnakeAndLadder()
        {
            int playerPosition = 0;

            Console.WriteLine("Welcome to Snake and Ladder!");

            while (playerPosition < 100) 
            {
                Console.WriteLine($"You are currently at position {playerPosition}.");
                Console.WriteLine("Enter your Number");
                int diceValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You rolled a {diceValue}.");                
                playerPosition += diceValue;

                    switch (playerPosition)
                    {
                        case 3:
                            playerPosition = 22;
                            Console.WriteLine("You landed on a ladder! Jump to position 22.");
                            break;
                        case 8:
                            playerPosition = 30;
                            Console.WriteLine("You landed on a ladder! Jump to position 30.");
                            break;
                        case 17:
                            playerPosition = 4;
                            Console.WriteLine("You landed on a snake! Go back to position 4.");
                            break;
                        case 32:
                            playerPosition = 62;
                            Console.WriteLine("You landed on a ladder! Jump to position 62.");
                            break;
                        case 33:
                            playerPosition = 13;
                            Console.WriteLine("You landed on a snake! Go back to position 13.");
                            break;
                        case 49:
                            playerPosition = 29;
                            Console.WriteLine("You landed on a snake! Go back to position 29.");
                            break;
                        case 57:
                            playerPosition = 40;
                            Console.WriteLine("You landed on a snake! Go back to position 40.");
                            break;
                        case 68:
                            playerPosition = 87;
                            Console.WriteLine("You landed on a ladder! Jump to position 87.");
                            break;
                        case 71:
                            playerPosition = 92;
                            Console.WriteLine("You landed on a ladder! Jump to position 92.");
                            break;
                        case 80:
                            playerPosition = 99;
                            Console.WriteLine("You landed on a ladder! Jump to position 99.");
                            break;
                        case 88:
                            playerPosition = 18;
                            Console.WriteLine("You landed on a snake! Go back to position 18.");
                            break;
                        case 95:
                            playerPosition = 51;
                            Console.WriteLine("You landed on a snake! Go back to position 51.");
                            break;
                        case 97:
                            playerPosition = 79;
                            Console.WriteLine("You landed on a snake! Go back to position 79.");
                            break;
                    }
                }
               
                if (playerPosition == 100)
                {
                    Console.WriteLine("Congratulations! You reached position 100 and won the game!");
                }
            }
         
    }
}
