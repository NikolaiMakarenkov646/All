using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Third
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmp = new BinaryTreeFindNode();
            var sub = CreateSubTree();
            var x = tmp.Find(CreateNewTree(),2);
            Console.Read();
        }


        private static Tree CreateSubTree()
        {
            Tree tree = new Tree();

            tree.Head = 99;
            tree.Left = null;
            tree.Right = new Tree()
            {
                Head = 8,
                Right = null,
                Left = new Tree()
                {
                    Head = 9,
                    Left = null,
                    Right = null
                }
            };
            return tree;

        }
        private static Tree CreateNewTree()
        {
            Tree tree = new Tree();

            tree.Head = 1;
            tree.Left = new Tree()
            {
                Head = 2,
                Left = new Tree()
                {
                    Head = 5,
                    Left = null,
                    Right = null
                },
                Right = new Tree()
                {
                    Head = 4,
                    Left = null,
                    Right = null
                }
            };
            tree.Right = new Tree()
            {
                Head = 3,
                Left = new Tree()
                {
                    Head = 6,
                    Left = null,
                    Right = null
                },
                Right = new Tree()
                {
                    Head = 88,
                    Left = null,
                    Right = new Tree()
                    {
                        Head = 8,
                        Right = null,
                        Left = new Tree()
                        {
                            Head = 9,
                            Left = null,
                            Right = null
                        }
                    }
                }
            };
            return tree;
        }
    }

    public class Tree
    {
        public int Head;
        public Tree Left;
        public Tree Right;
    };
}
