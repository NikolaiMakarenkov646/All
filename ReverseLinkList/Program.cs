using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintListNode(CreateLinkList());

            //PrintListNode(CreateLinkList());
            //var revLinkList = new ReverseLinkList();
            //var result1 = revLinkList.Reverse(CreateLinkList());
            //PrintListNode(result1);
            ////Console.Read();
            //Console.WriteLine("************");

            var revLinkListStack = new ReverseLinkListStack();
            var result2 = revLinkListStack.Reverse(CreateLinkList());
            PrintListNode(result2);
            Console.Read();
            Console.WriteLine("************");

            var myinkList = new MyLinkList();
            //var result3 = myinkList.GetMaxFromLinkList(CreateLinkList());
            //Console.WriteLine(result3);

            //var result4 =myinkList.DeleteFromLinkList(CreateLinkList(),4);
            //PrintListNode(result4);

            //var result5 = myinkList.ReplaceValueInLinkList(CreateLinkList(), 4, 99);
            //PrintListNode(result5);

            var result6 = myinkList.Reverse(CreateLinkList());
            PrintListNode(result6);
            Console.Read();
        }

        static ListNode CreateLinkList()
        {
            return new ListNode()
            {
                Value = 1,
                Next = new ListNode()
                {
                    Value = 2,
                    Next = new ListNode()
                    {
                        Value = 3,
                        Next = new ListNode()
                        {
                            Value = 4,
                            Next = new ListNode()
                            {
                                Value = 5,
                                Next = null
                                //Next = new ListNode()
                                //{
                                //    Value = 6,
                                //    Next = new ListNode()
                                //    {
                                //        Value = 7,
                                //        Next = null
                                //    }
                                //}
                            }
                        }
                    }
                }
            };
        }

        static void PrintListNode(ListNode lst)
        {
            Console.Write("{0}, ", lst.Value);
            while (lst.Next != null)
            {
                lst = lst.Next;
                Console.Write("{0}, ", lst.Value);
            }
            Console.WriteLine();
        }

    }
}
