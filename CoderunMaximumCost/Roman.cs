namespace CoderunMaximumCost
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Markup;

    internal class Roman
    {
        private static readonly Dictionary<char, int> Values = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static void Foo()
        {
            while (true)
            {
                Console.Write("Введите число: ");
                var inputString = Console.ReadLine().ToUpper();
                if(inputString.Length == 0)
                {
                    break;
                }
                Console.WriteLine($"Результат: {RomanToInt(inputString)}");
            }
        }

        private static int RomanToInt(string s)
        {
            var sum = 0;
            for(int i = s.Length - 1; i >= 0; i--)
            {
                var number = Values[s[i]];
                if (number >= sum || number == Values[s[i + 1]])
                {
                    sum += number;
                }
                else
                {
                    sum -= number;
                }
            }
            return sum;
        }
    }
}
