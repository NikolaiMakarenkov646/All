using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        Node reverseUtil(Node curr, Node prev)
        {

            /* If last node mark it head*/
            if (curr.next == null)
            {
                head = curr;

                /* Update next to prev node */
                curr.next = prev;
                return null;
            }

            /* Save curr->next node for recursive call */
            Node next1 = curr.next;

            /* and update next ..*/
            curr.next = prev;

            reverseUtil(next1, curr);
            return head;
        }
    }

    class LinkedList
    {
        static Node head;
        static class Node
        {
            int data;
            Node next;

            Node(int d)
            {
                data = d;
                next = null;
            }
        }
    }
}
