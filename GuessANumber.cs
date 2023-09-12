﻿using System;

namespace GuessANumber
{
    internal class GuessANumber
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int computerNumber = random.Next(1, 101);

            while (true)
            {
                Console.WriteLine("Guess a number (1 - 100): ");

                string playerInput = Console.ReadLine();

                bool isValid = int.TryParse(playerInput, out int playerNumber);

                if (isValid)
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You guessed it!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Pres [x] to exit the game: ");
                        playerInput = Console.ReadLine();
                        if (playerInput == "x")
                        {
                            break;
                        }
                        else
                        {
                            computerNumber = random.Next(1, 101);
                            Console.Clear();
                            continue;
                        }
                        
                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.WriteLine("Too High!");
                    }
                    else
                    {
                        Console.WriteLine("Too Low!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
