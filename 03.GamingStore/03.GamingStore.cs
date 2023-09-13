using System;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float balance = float.Parse(Console.ReadLine());
            string gameName = Console.ReadLine();
            float spends = 0;

            while (gameName != "Game Time")
            {
                float gamePrice = 0;
                switch (gameName)
                {
                    case "OutFall 4":
                        gamePrice = 39.99f;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99f;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99f;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99f;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99f;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99f;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (gamePrice > balance)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (gamePrice != 0)
                {
                    balance -= gamePrice;
                    spends += gamePrice;
                    Console.WriteLine($"Bought {gameName}");
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                gameName = Console.ReadLine();
            }

            if (gameName == "Game Time")
            {
                Console.WriteLine($"Total spent: ${spends:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}
