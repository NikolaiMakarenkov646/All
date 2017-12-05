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
            //var btEfficient = new BinarryTreeAllPathsEfficient();
            ////var result = btEfficient.GetMaxCountDistinct(CreateNewTree());
            //var result9 = btEfficient.GetMaxNodes(CreateNewTree());
            //var result10 = btEfficient.GetMaxSumNode(CreateNewTree());
            //Console.WriteLine(result9);
            //Console.WriteLine(result10);
            //Console.Read();

            var btMaxDeepNumber = new BinarryTreeMaxDeepNode();
            Node result2 = new Node();
            btMaxDeepNumber.GetMaxDeepNodeValue(null,-1,result2);
            Console.Read();
            //btMaxDeepNumber.GetMaxDeepNodeValue(CreateNewTree(),0,result2);
            ////Console.WriteLine(btMaxDeepNumber.GetMaxDeepNodeIndex(CreateNewTree(),0));
            //Console.Read();

            //var btMaxNumber = new BinarryTreeMaxNumber();
            //Console.WriteLine(btMaxNumber.GetMaxNumber(CreateNewTree()));
            //Console.Read();


            //var paths = new BinarryTreeAllPaths();
            //var allPaths = paths.GetAllPaths(CreateNewTree());
            //Console.Read();
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
                    Head = 3,
                    Left = new Tree()
                    {
                        Head = 5,
                        Left = null,
                        Right = null,
                    },
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
                    Head = 7,
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
