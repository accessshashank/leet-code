using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Question21
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            var f = MergeTwoLists(l1, l2);
        }
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null) return null;
            if (l1 == null && l2 != null) return l2;
            if (l1 != null && l2 == null) return l1;

            var p = l1;
            var q = l2;
            ListNode final = new ListNode(0);
            ListNode r = final;
            ListNode temp = null;
            while(p != null && q != null)
            {
                if(p.val <= q.val)
                {
                    temp = new ListNode(p.val);
                    r.next = temp;
                    p = p.next;
                    r = temp;
                }
                else
                {
                    temp = new ListNode(q.val);
                    r.next = temp;
                    q = q.next;
                    r = temp;
                }
            }

            if(p == null)
            {
                r.next = q;
            }

            if(q == null)
            {
                r.next = p;
            }
            return final.next;
        }
    }
}
