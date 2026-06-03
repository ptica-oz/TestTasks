namespace TestTasks
{
    using System;
    using System.Text;

    internal class MergeTwoSortedLists
    {
        public static void Foo()
        {
            while (true)
            {
                Console.Write("Введите первую последовательность: ");
                var firstInput = Console.ReadLine();
                if (firstInput.Length == 0)
                {
                    break;
                }

                Console.Write("Введите вторую последовательность: ");
                var secondInput = Console.ReadLine();
                if (secondInput.Length == 0)
                {
                    break;
                }

                var result = MergeTwoLists(ListNode.GetListNode(firstInput), ListNode.GetListNode(secondInput));
                StringBuilder sb = new();
                while (result != null)
                {
                    sb.Append(result.val);
                    result = result.next;
                }
                Console.WriteLine("Результат: " + sb.ToString());
            }
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var cursor1 = list1;
            var cursor2 = list2;
            int? v1;
            int? v2;
            List<int> sortValues = new();
            do
            {
                v1 = cursor1 != null ? cursor1.val : null;
                v2 = cursor2 != null ? cursor2.val : null;
                if (v1 != null && v2 != null)
                {
                    if (v1.Value <= v2.Value)
                    {
                        sortValues.Add(v1.Value);
                        cursor1 = cursor1.next;
                    }
                    else
                    {
                        sortValues.Add(v2.Value);
                        cursor2 = cursor2.next;
                    }
                }
                else if(v1 == null && v2 != null)
                {
                    sortValues.Add(v2.Value);
                    cursor2 = cursor2.next;
                }
                else if (v2 == null && v1 != null)
                {
                    sortValues.Add(v1.Value);
                    cursor1 = cursor1.next;
                }
            }
            while (cursor1 != null || cursor2 != null);
            return GetListNode(sortValues);
        }

        private static ListNode GetListNode(List<int> list)
        {
            var array = list.ToArray();
            ListNode currentNode = null;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                var newListNode = new ListNode(array[i], currentNode);
                currentNode = newListNode;
            }
            return currentNode;
        }
    }
}
