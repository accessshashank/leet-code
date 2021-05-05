using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question23
    {
        static void Main(string[] args)
        {
            var item1 = new ListNode(1, new ListNode(4, new ListNode(5)));
            var item2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            var item3 = new ListNode(2, new ListNode(6));

            var items = new ListNode[] { item1, item2, item3 };
            var merged = MergeKLists(items);
        }

        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Count() == 0) return null;

            var values = new List<int>();
            foreach(var listItem in lists)
            {
                var node = listItem;
                while(node != null)
                {
                    values.Add(node.val);
                    node = node.next;
                }
            }

            values.Sort();
            
            ListNode p = new ListNode(0);
            var merged = p;
            ListNode temp = null;
            foreach(var item in values)
            {
                temp = new ListNode(item);
                p.next = temp;
                p = p.next;
            }
            return merged.next;
        }
    }
}
