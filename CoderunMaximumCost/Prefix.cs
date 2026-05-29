namespace TestTasks
{
    using System;
    using System.Text;

    internal class Prefix
    {
        public static void Foo()
        {
            while(true)
            {
                Console.Write("Введите слова: ");
                var inputString = Console.ReadLine();
                if(inputString.Length == 0)
                {
                    break;
                }
                Console.WriteLine("Результат: " + LongestCommonPrefix(inputString.Split(' ')));
            }
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            var match = true;
            StringBuilder prefix = new();
            for(int i = 0; i < strs[0].Length; i++)
            {
                var ch = strs[0][i];
                for(int j = 1; j < strs.Length; j++)
                {
                    if(i == strs[j].Length || strs[j][i] != ch)
                    {
                        match = false;
                        break;
                    }
                }
                if(match)
                {
                    prefix.Append(ch);
                }
                else
                {
                    break;
                }
            }
            return prefix.ToString();
        }
    }
}
