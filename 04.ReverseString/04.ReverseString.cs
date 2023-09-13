using System;
using System.Linq;

namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputToArray = input.ToCharArray();

            Array.Reverse(inputToArray);
            input = new string(inputToArray);

            Console.WriteLine(input);
        }
    }
}
