using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkList
{
    public class MyLinkList
    {
        public int GetMaxFromLinkList(ListNode listNode)
        {
            if (listNode.Next == null)
            {
                return listNode.Value;
            }
            int result = listNode.Value;
            var next = GetMaxFromLinkList(listNode.Next);

            //if (next > result)
            //    result = next;
            //return result;
            return Math.Max(result, next);
        }

        public ListNode DeleteFromLinkList(ListNode listNode, int toDelete)
        {
            if (listNode.Value == toDelete)
            {
                return listNode.Next;
            }
            var nextNode = DeleteFromLinkList(listNode.Next, toDelete);
            listNode.Next = nextNode;
            return listNode;
        }

        public ListNode ReplaceValueInLinkList(ListNode listNode, int valueToReplace,int newValue)
        {
            if (listNode.Value == valueToReplace)
            {
                listNode.Value = newValue;
                return listNode;
            }
            var nextNode = ReplaceValueInLinkList(listNode.Next, valueToReplace,newValue);
            listNode.Next = nextNode;
            return listNode;
        }

        public ListNode Reverse(ListNode listNode)
        {
            if (listNode.Next == null)
            {
                return listNode;
            }
            var result = Reverse(listNode.Next);

            listNode.Next.Next = listNode;
            listNode.Next = null;

            return result;
        }
    }
}
