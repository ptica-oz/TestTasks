namespace CoderunMaximumCost
{
    using System;
    using System.Linq;

    internal class TwoSum
    {
        public static void Foo()
        {
            while(true)
            {
                Console.Write("Введите числа: ");
                var inputString = Console.ReadLine();
                if (inputString.Length == 0)
                {
                    break;
                }
                var nums = inputString.Split(' ').Select(v => int.Parse(v)).ToArray();
                
                Console.Write("Сумма: ");
                var targetString = Console.ReadLine();
                if(targetString.Length == 0)
                {
                    break;
                }

                var indexes = GetTwoSum(nums, int.Parse(targetString));
                Console.WriteLine($"{indexes[0]} {indexes[1]}");
            }
        }

        public static int[] GetTwoSum(int[] nums, int target)
        {
            for(int i = 0; i < nums.Length - 1; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] { i, j};
                    }
                }
            }
            int[] indexes = new[] { 0, 0 };
            return indexes;
        }
    }
}
