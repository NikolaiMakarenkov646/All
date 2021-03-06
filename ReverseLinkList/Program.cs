﻿using System;
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

            var tmp = new ReverseLinkListWhile();
            var result = tmp.Reverse(CreateLinkList());
            PrintListNode(result);
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
                                Next = new ListNode()
                                {
                                    Value = 6,
                                    Next = new ListNode()
                                    {
                                        Value = 7,
                                        Next = null
                                    }
                                }
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
