namespace OneWord
{
    internal class Number
    {
        internal static int AskOne()
        {
            do
            {
                Console.WriteLine("Please, enter the number.");
                var userAnswer = Console.ReadLine();
                if (uint.TryParse(userAnswer, out uint result) && result > 1)
                {
                    return (int)result;
                }
                Console.WriteLine("Can't parse entered string to integer number greater than 1");
            }
            while (true);
        }

        internal static (int first, int second) AskPair()
        {
            uint first;
            do
            {
                Console.WriteLine("Please, enter first number.");
                var userAnswer = Console.ReadLine();
                if (uint.TryParse(userAnswer, out first))
                {
                    break;
                }
                Console.WriteLine("Can't parse entered string to unsighn integer value.");
            }
            while (true);

            do
            {
                Console.WriteLine("Please, enter second number.");
                var userAnswer = Console.ReadLine();
                if (uint.TryParse(userAnswer, out uint second))
                {
                    return ((int)first, (int)second);
                }
                Console.WriteLine("Can't parse entered string to unsighn integer value.");
            }
            while (true);
        }
    }
}
