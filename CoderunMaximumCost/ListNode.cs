namespace TestTasks
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode GetListNode(string str)
        {
            var values = str.Split(',');
            ListNode currentNode = null;
            for (int i = values.Length - 1; i >= 0; i--)
            {
                var newListNode = new ListNode(int.Parse(values[i]), currentNode);
                currentNode = newListNode;
            }
            return currentNode;
        }
    }
}