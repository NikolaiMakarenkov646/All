using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkList
{
    public class ReverseLinkListWhile
    {
        public ListNode Reverse(ListNode currentNode)
        {
            ListNode prevNode = null;
            HashSet<ListNode> lst = new HashSet<ListNode>();
            
            while (currentNode != null)
            {
                var nextNode = currentNode.Next;
                currentNode.Next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
            }
            return prevNode;

        }
    }
}
