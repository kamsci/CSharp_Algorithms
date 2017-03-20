using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool loopOn = true;

            while (loopOn)
            {
                Console.WriteLine("Type the number corresponding to the action you want to take: ");
                Console.WriteLine("   1 = Reverse entire string");
                Console.WriteLine("   2 = Reverse Words in a string");
                Console.WriteLine("   3 = Remove substrings from a string");
                Console.WriteLine("   4 = Determine if strings are permutations of each other");

                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        Console.Write("Enter a sentance or word: ");
                        string input1 = Console.ReadLine();
                        Console.WriteLine("Result: {0}", Strings.ReverseString(input1));
                        break;
                    case "2":
                        Console.Write("Enter a sentance or word: ");
                        string input2 = Console.ReadLine();
                        Console.WriteLine("Result: {0}", Strings.ReverseWords(input2));
                        break;
                    case "3":
                        Console.Write("Enter the character group to be removed: ");
                        string input3first = Console.ReadLine();
                        Console.Write("Enter a sentance or word: ");
                        string input3second = Console.ReadLine();
                        Console.WriteLine("Result: {0}", Strings.RemoveInput(input3first, input3second));
                        break;
                    case "4":
                        Console.Write("Enter the first string to compare: ");
                        string input4first = Console.ReadLine();
                        Console.Write("Enter the second string to compare: ");
                        string input4second = Console.ReadLine();
                        Console.WriteLine("Result: {0}", Strings.IsPermutation(input4first, input4second));
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.Write("Again? y/n: ");
                string again = Console.ReadLine();
                Console.WriteLine();

                if(again.Equals("n"))
                {
                    loopOn = false;
                }
                
            }
        }
    }
}
