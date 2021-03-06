using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public ListNode Head { get; set; }

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            ListNode Head = new ListNode();
        }

        /** Get the val of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            ListNode current = Head;
            if(current == null) { return -1; }

                for (int i = 0; i < index; i++)
                {
                    if(current.next != null)
                    {
                         current = current.next;
                    } else
                    {
                    return -1;
                    }            
                }
                return current.val;
        }

        /** Add a node of val val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            ListNode Node = new ListNode(val);
            Node.next = Head;
            Head = Node;
        }

        /** Append a node of val val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (Head == null)
            {
                AddAtHead(val);
            }
            else
            {
                ListNode current = Head;
                while (current.next != null)
                {
                    current = current.next;
                }

                ListNode Node = new ListNode(val);
                current.next = Node;
            }
        }

        /** Add a node of val val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if(index == 0)
            {
                AddAtHead(val);
            }
            else 
            { 
            ListNode InsertedNode = new ListNode(val);
            ListNode CurrentNode = Head;
            ListNode PreviousNode = CurrentNode;

            for (int i = 0; i < index; i++)
            {
                if (CurrentNode.next == null && i == (index-1))
                {
                    CurrentNode.next = InsertedNode;
                    goto done;
                }
                else if (CurrentNode.next == null && i != (index-1))
                {
                    goto done;     
                }
                else 
                {
                 PreviousNode = CurrentNode;
                 CurrentNode = CurrentNode.next;
                }
            }
                InsertedNode.next = CurrentNode;
                PreviousNode.next = InsertedNode;
                done:;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            ListNode currentNode = Head;
            ListNode previousNode = currentNode;
            if (Head == null)
            {
                goto done;
            } else if(index == 0)
            {
                Head = Head.next;
            }
            {
                for (int i = 0; i < index; i++)
                {
                    if (currentNode.next == null)
                    {
                        goto done;
                    }
                    else
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.next;
                    }
                }
                previousNode.next = currentNode.next;
            
            }
        done:;
        }
    }
}
