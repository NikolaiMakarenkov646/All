using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Third
{
    public class BinarryTreeMaxDeepth
    {
        public int GetMaxDepthNode(Tree tree)
        {
            var result = CollectAllDepthNodes(tree, new List<int>());
            return result.Max();
        }

        private List<int> CollectAllDepthNodes(Tree tree, List<int> result)
        {
            if (tree == null)
            {
                return result;
            }
            if (tree.Left == null && tree.Right == null)
            {
                result.Add(tree.Head);
                return result;
            }
            CollectAllDepthNodes(tree.Left, result);
            CollectAllDepthNodes(tree.Right, result);

            return result;
        }
    }
}
