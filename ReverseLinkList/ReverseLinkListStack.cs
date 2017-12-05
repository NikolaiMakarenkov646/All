using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkList
{
    public class ReverseLinkListStack
    {
        public ListNode Reverse(ListNode lnkList)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(lnkList.Value);

            while (lnkList.Next != null)
            {
                lnkList = lnkList.Next;
                stack.Push(lnkList.Value);
            }
            PrintStack(stack);
            var result = FillLinkList(stack);
            return result;
        }

        private void PrintStack(Stack<int> stack)
        {
            foreach (var i in stack)
            {
                Console.Write("{0} ,", i);
            }
            Console.WriteLine();
        }

        private static ListNode FillLinkList(Stack<int> stack)
        {
            if (stack.Count == 0)
            {
                return null;
            }
            var result = new ListNode();
            result.Value = stack.Pop();
            result.Next = FillLinkList(stack);
            return result;
        }
    }
}
