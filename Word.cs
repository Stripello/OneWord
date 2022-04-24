using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWord
{
    internal static class Word
    {
        internal static string Reverse(string inputWord)
        {
            return "Reverse of inputed word = " + inputWord.Reverse().ToArray();
        }

        internal static void GetCertainChar(string inputWord, int position)
        {
            if (position < 0)
            {
                Console.WriteLine("Can't get symbol with index lesser then 0.");
                return;
            }
            if (inputWord.Length - 1 < position)
            {
                Console.WriteLine($"Can't show you symbol number {position} because entered word is too short.");
            }
            else
            {
                Console.WriteLine($"Char number {position} = {inputWord[position]}");
            }
        }

        internal static void DefineEqity(string inputWord, int X, int Y)
        {
            if (inputWord.Length - 1 >= Y)
            {
                var isEqual = inputWord[X].Equals(inputWord[Y]);
                if (isEqual)
                {
                    Console.WriteLine($"Symbols {X} and {Y} is eqal.");
                }
                else
                {
                    Console.WriteLine($"Symbols {X} and {Y} are not euqal.");
                }
                Console.WriteLine($"Concatination of this two symbols = {inputWord[X]}{inputWord[Y]}.");
            }
            else
            {
                Console.WriteLine($"Can't definite equity of symbol {X} and {Y} because entered word is too short.");
            }

        }

        internal static void SwapPlaces(string inputWord)
        {
            var length = inputWord.Length;
            var powList = Number.AskOneToMakeArray(length);

            var randList = new List<int>();
            var randomizer = new Random();
            for (int i = powList.Count; i > 0; i--)
            {
                var temp = randomizer.Next(i);
                randList.Add(powList[temp]);
                powList.RemoveAt(temp);
            }
            Console.Write("Word with randomly changed position of some chars = ");
            for (int i = 0; i < length; i++)
            {
                if (randList.Contains(i))
                {
                    Console.Write(inputWord[randList[0]]);
                    randList.RemoveAt(0);
                }
                else
                {
                    Console.Write(inputWord[i]);
                }
            }
        }

        internal static void Neighbours(string inputWord)
        {
            var tempCharList = new List<char>();
            foreach (var ca in inputWord)
            {
                if (!tempCharList.Contains(ca))
                {
                    tempCharList.Add(ca);
                }
            }
            Console.WriteLine($"Entered word contains {tempCharList.Count} different chars.");
        }

        internal static void HalfOperations(string inputWord)
        {
            var halfLength = inputWord.Length/2;
            var firstHalf = inputWord.Substring(0, halfLength);
            Console.WriteLine($"First half of inputed word = {firstHalf}.");

            bool isEven = inputWord.Length % 2 == 0;
            var secondHalf = String.Empty;
            if (isEven)
            {
                secondHalf = inputWord[halfLength..];
                Console.WriteLine($"Word reversed by halfs = {secondHalf}{firstHalf}");
            }
            else
            {
                secondHalf = inputWord[(halfLength + 1)..];
                Console.WriteLine($"Word reversed by halfs = {secondHalf}{inputWord[halfLength]}{firstHalf}");
            }

            var temp = secondHalf.ToCharArray();
            Array.Reverse(temp);
            if (String.Equals(firstHalf, new string( temp )))
            {
                Console.WriteLine("This word is \"shifter\".");
            }
            else
            {
                Console.WriteLine("This word is not \"shifter\".");
            }
        }
    }
}
