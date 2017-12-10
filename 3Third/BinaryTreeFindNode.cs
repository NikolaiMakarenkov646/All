using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Third
{
    public class BinaryTreeFindNode
    {
        public bool Contain(Tree tree, Tree toFind)
        {
            if (tree == toFind)
                return true;
            if (tree == null)
                return false;

            var resLeft= Contain(tree.Left, toFind);
            var resRight = Contain(tree.Right, toFind);
            return resRight || resLeft;
        }

        public Tree Find(Tree tree, int value)
        {
            if (tree==null)
            {
                return null;
            }
            if (tree.Head == value)
            {
                return tree;
            }
            var left = Find(tree.Left, value);
            var right = Find(tree.Right, value);
            if (left != null)
                return left;
            if (right != null)
                return right;
            return null;
        }
    }
}
