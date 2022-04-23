namespace OneWord
{
    internal class Number
    {
        internal static List<int> AskOneToMakeArray(int length)
        {
            uint result;
            do
            {

                Console.WriteLine("Please, enter the number.");
                var userAnswer = Console.ReadLine();
                if (uint.TryParse(userAnswer, out result) && result > 1)
                {
                    break;
                }
                Console.WriteLine("Can't parse entered string to integer number greater than 1");
            }
            while (true);

            var answer = new List<int>();
            var i = 0;
            do
            {
                var temp = (int)Math.Pow(result, i);
                if (temp <= length - 1)
                {
                    answer.Add(temp);
                    i++;
                }
                else
                {
                    break;
                }
            }
            while (true);
            return answer;
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
