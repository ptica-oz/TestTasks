namespace TestTasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class AddTwoNumbersClass
    {
        public static void Foo()
        {
            while(true)
            {
                Console.Write("Введите первую последовательность: ");
                var firstInput = Console.ReadLine();
                if(firstInput.Length == 0)
                {
                    break;
                }

                Console.Write("Введите вторую последовательность: ");
                var secondInput = Console.ReadLine();
                if (secondInput.Length == 0)
                {
                    break;
                }

                var result = AddTwoNumbers(GetListNode(firstInput), GetListNode(secondInput));
                StringBuilder sb = new();
                while(result != null)
                {
                    sb.Append(result.val);
                    result = result.next;
                }
                Console.WriteLine("Результат: " + sb.ToString());
            }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode headNode = null;
            ListNode currentNode = null;
            var cursor1 = l1;
            var cursor2 = l2;
            var isMore = false;
            do
            {
                var v1 = cursor1 == null ? 0 : cursor1.val;
                var v2 = cursor2 == null ? 0 : cursor2.val;
                var sum = isMore ? v1 + v2 + 1 : v1 + v2;
                isMore = sum > 9;
                var newNode = new ListNode(isMore ? sum % 10 : sum, null);
                if (headNode == null)
                {
                    headNode = newNode;
                    currentNode = newNode;
                }
                else
                {
                    currentNode.next = newNode;
                    currentNode = newNode;
                }

                cursor1 = cursor1 != null ? cursor1.next : null;
                cursor2 = cursor2 != null ? cursor2.next : null;
            }
            while (cursor1 != null || cursor2 != null);
            if (isMore)
            {
                currentNode.next = new ListNode(1, null);
            }

            return headNode;
        }

        private static ListNode GetListNode(string str)
        {
            var values = str.Split(',');
            ListNode currentNode = null;
            for(int i = values.Length - 1; i >= 0; i--)
            {
                var newListNode = new ListNode(int.Parse(values[i]), currentNode);
                currentNode = newListNode;
            }
            return currentNode;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
