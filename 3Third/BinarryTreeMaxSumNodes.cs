using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Third
{
    public class BinarryTreeMaxSumNodes
    {
        public int GetMaxSumNode(Tree tree)
        {
            if (tree == null)
            {
                return 0;
            }

            var leftResult = GetMaxSumNode(tree.Left);
            var rightResult = GetMaxSumNode(tree.Right);
            return Math.Max(rightResult, leftResult) + tree.Head;
        }
    }
}
