namespace CoderunMaximumCost
{
    using System;

    internal class Palindrome
    {
        public static void CheckString()
        {
            while (true)
            {
                Console.Write("Введите строку: ");
                var inputString = Console.ReadLine().ToUpper();
                if(inputString.Length == 0)
                { 
                    break; 
                }

                var leftIndex = 0;
                var rightIndex = inputString.Length - 1;
                var isPalindrome = true;

                while(leftIndex < rightIndex)
                {
                    if (inputString[leftIndex] != inputString[rightIndex])
                    {
                        isPalindrome = false;
                        Console.WriteLine("неть!");
                        break;
                    }
                    leftIndex++;
                    rightIndex--;
                }
                if(isPalindrome)
                {
                    Console.WriteLine("угу");
                }
            }
        }
    }
}
