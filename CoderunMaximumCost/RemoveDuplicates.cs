namespace TestTasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class RemoveDuplicates
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

                var array = inputString.Split(',').Select(s => int.Parse(s)).ToArray();

                var count = DoRemoveDuplicates(array);
                Console.WriteLine("Результат: " + count);
            }
        }

        public static int DoRemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int write = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[write] = nums[i];
                    write++;
                }
            }

            return write;
        }
    }
}
