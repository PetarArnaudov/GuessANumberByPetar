using System;

namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[] result = new char[rows];

            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();
                int inputLenght = input.Length;
                int mainDigit = int.Parse(input) % 10;

                int offset = (mainDigit - 2) * 3;
                int letterIndex = offset + inputLenght - 1;

                if (mainDigit >= 8)
                {
                    letterIndex += 1;
                }

                if (mainDigit == 0)
                {
                    result[i] = ' ';
                }
                else
                {
                    result[i] = (char)(97 + letterIndex);
                }
            }

            Console.WriteLine(result);
        }
    }
}
