using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1A
            var listOfFestiveGreetings = new List<string>() { "Glad", "Påsk", "Forefront", "2021", "Från", "Simon" };
            PrintItemsInABox(listOfFestiveGreetings);

            // 1B
            int boardSize = GetBoardSizeFromUser();
            var pussel = new ChessQueens(boardSize);
            pussel.SolveByForce();
            pussel.ShowBoard();
            Console.WriteLine($"\nSolved by bruteforce after {pussel.Tries} tries");
        }

        private static int GetBoardSizeFromUser()
        {
            Console.WriteLine("Please specify boardsize (Must be an integer > 3): ");
            try
            {
                var userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int num))
                {
                    if (num < 4)
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        if (num > 9)
                        {
                            Console.WriteLine("Yeah, this will take a while, grab a coffee #EfficientAndBeautifulCode");
                        }
                        return num;
                    }
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid input, 4-Queen pussel will be solved.");
                return 4;
            }
        }

        private static void PrintItemsInABox(List<string> list)
        {
            Console.WriteLine("*************");
            foreach (var item in list)
            {
                Console.WriteLine("* {0,9} *", item);
            }
            Console.WriteLine("*************\n");
        }
    }
}
