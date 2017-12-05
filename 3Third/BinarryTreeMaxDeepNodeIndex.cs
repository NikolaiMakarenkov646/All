using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _3Third
{
    public class BinarryTreeMaxDeepNodeIndex
    {

        public int GetMaxDeepNodeIndex(Tree tree, int counter)
        {
            if (tree == null)
            {
                return counter;
            }
            counter++;
            int leftCounterResult = GetMaxDeepNodeIndex(tree.Left, counter);
            int rightCounterResult = GetMaxDeepNodeIndex(tree.Right, counter);

            if (leftCounterResult > rightCounterResult)
                return leftCounterResult;

            return rightCounterResult;
        }

        public int GetMaxDeepNodeIndex2(Tree tree)
        {
            if (tree == null)
                return 0;
            int left = GetMaxDeepNodeIndex2(tree.Left) + 1;
            int right = GetMaxDeepNodeIndex2(tree.Right) + 1;
            return Math.Max(left, right);
        }
    }
}
