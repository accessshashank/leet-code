using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
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
    }
    class Question2
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode();
            l1.val = 2;
            l1.next = new ListNode();
            l1.next.val = 4;
            l1.next.next = new ListNode();
            l1.next.next.val = 3;

            ListNode l2 = new ListNode();
            l2.val = 5;
            l2.next = new ListNode();
            l2.next.val = 6;
            l2.next.next = new ListNode();
            l2.next.next.val = 4;

            var result = AddTwoNumbers(l1, l2);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode currentNode = new ListNode();
            ListNode p = currentNode;
            int carry = 0;
            while(l1 != null || l2 != null)
            {
                int val1 = l1 != null ? l1.val : 0;
                int val2 = l2 != null ? l2.val : 0;
                int sum = carry + val1 + val2;
                carry = sum / 10;
                var temp = new ListNode(sum % 10);
                p.next = temp;
                p = temp;
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;

            }

            if(carry > 0)
            {
                p.next = new ListNode(carry);
            }
            return currentNode.next;
        }
    }
}
