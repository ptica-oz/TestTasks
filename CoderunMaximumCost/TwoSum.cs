namespace CoderunMaximumCost
{
    using System;
    using System.Linq;

    delegate void Message();

    internal class TwoSum
    {
        public Message msg;

        public  void Foo()
        {
            msg = new Message(Person.Do);
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
            Dictionary<int, int> dic = new();
            for(int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    return new[] { i, dic[nums[i]] };
                }

                dic[target - nums[i]] = i;
            }
            return new[] { -1, -1 };
        }


    }

    public class Person
    {
        public string name = "Tom";
        public int age = 1;
        public Person()
        {
                
        }

        public static void Do()
        { }
    }

    public class Employee : Person
    {
        public string Compani { get; set; }
        
        public override bool Equals(object? obj)
        {
            if (obj is Person person) return name == person.name;
            return false;
        }
    }
}
