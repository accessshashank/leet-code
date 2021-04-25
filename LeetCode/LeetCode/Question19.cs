using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question19
    {
        static void Main(string[] args)
        {
            //ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            //ListNode head = new ListNode(1);
            ListNode head = new ListNode(1, new ListNode(2));
            int n = 1;
            RemoveNthFromEnd(head, n);
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var p = head;
            int len = 1;
            while(p.next != null)
            {
                p = p.next;
                len++;
            }

            int nodeToDel = len - n + 1;
            if (nodeToDel == 1)
                return head.next;
           
            p = head;
            var q = p;
            int counter = 1;
            while(counter < nodeToDel)
            {
                counter++;
                p = q;
                q = q.next;
            }

            p.next = q.next;

            return head;

        }
    }
}
