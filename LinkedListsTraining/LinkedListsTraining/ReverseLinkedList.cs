using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining.ReverseLinkedList
{
    public class Solution
    {
        ListNode previousNode = null;
        public ListNode ReverseList (ListNode head)
        {           
            if (head != null)
            {
                var temporaryNode = head.next;
                head.next = previousNode;
                previousNode = head;
                head = temporaryNode;
                ReverseList(head);
            }           
            return previousNode;
        }

    }
}
