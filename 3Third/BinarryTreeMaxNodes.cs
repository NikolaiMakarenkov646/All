using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Third
{
    public class BinarryTreeMaxNodes
    {
        public int GetMaxNodes(Tree tree)
        {
            if (tree == null)
            {
                return 0;
            }
            var leftResult = GetMaxNodes(tree.Left);
            var rightResult = GetMaxNodes(tree.Right);
            return Math.Max(rightResult, leftResult) + 1;
        }
    }
}
