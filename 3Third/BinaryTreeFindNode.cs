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

        //public Tree Find(Tree tree, int value)
        //{
            
        //}
    }
}
