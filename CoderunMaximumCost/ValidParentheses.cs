namespace TestTasks
{
    internal class ValidParentheses
    {
        public static void Foo()
        {
            while (true)
            {
                Console.Write("Введите строку: ");
                var inputString = Console.ReadLine();
                if (inputString.Length == 0)
                {
                    break;
                }
                Console.WriteLine("Результат: " + IsValid(inputString));
            }
        }

        public static bool IsValid(string s)
        {
            var openBracket = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };
            Stack<char> openList = new();
            
            for (int i = 0; i < s.Length; i++)
            {
                if (openBracket.ContainsValue(s[i]))
                {
                    openList.Push(s[i]);
                }
                else if (openBracket.ContainsKey(s[i]))
                {
                    var openPair = openBracket.ContainsKey(s[i]);
                    if (openList.Count == 0 || openList.Pop() != openBracket[s[i]])
                    {
                        return false;
                    }
                }
            }
            return openList.Count == 0;
        }
    }
}
