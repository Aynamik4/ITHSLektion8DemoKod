using System;
using System.Diagnostics;

namespace TernaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ternary 
            string s = Console.ReadKey(true).Key == ConsoleKey.S ? "Sant" : "Falskt";

            //if (Console.ReadKey(true).Key == ConsoleKey.S)
            //    s = "Sant";
            //else
            //    s = "Falskt";

            Console.WriteLine(s);
        }
    }
}
