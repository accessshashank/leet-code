using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question24
    {
        static void Main(string[] args)
        {
            var node = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            var head = SwapPairs(node);
        }

        public static  ListNode SwapPairs(ListNode head)
        {
            if (head == null) return null;
            var p = head;
            var q = p.next;
            while(p != null && q != null)
            {
                int val1 = p.val;
                p.val = q.val;
                q.val = val1;
                p = q.next;
                q = p != null ? p.next : null;
            }

            return head;
        }
    }
}
