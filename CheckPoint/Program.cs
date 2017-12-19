using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static Tree CreateTree()
        {
            return null;
        }

        private Result SearchInBst(Tree tree, int message)
        {
            var result = SearchInTree(tree, message);
            return result == null ? Result.GotMessage : Result.IgnoreMessage;
        }

        private static Tree SearchInTree(Tree tree, int message)
        {
            while (true)
            {
                if (tree == null || tree.Head == message)
                    return tree;

                if (tree.Head > message)
                {
                    tree = tree.Left;
                    continue;
                }

                tree = tree.Right;
            }
        }

        private static Tree SearchInTreerecursive(Tree tree, int message)
        {
            if (tree == null || tree.Head == message)
                return tree;

            if (tree.Head > message)
                return SearchInTree(tree.Left, message);

            return SearchInTree(tree.Right, message);
        }

    }
}
