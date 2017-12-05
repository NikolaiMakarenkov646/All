using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkList
{
    public class ReverseLinkList
    {
        public ListNode Reverse(ListNode listNode)
        {
            if (listNode.Next == null)
            {
                return listNode;
            }
            ListNode result = Reverse(listNode.Next);

            ListNode nextnode = listNode.Next;
            nextnode.Next = listNode;
            listNode.Next = null;

            return result;
        }
    }
}
