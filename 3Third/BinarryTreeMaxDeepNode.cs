using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _3Third
{
    public class BinarryTreeMaxDeepNode
    {
        public int GetMaxDeepNodeIndex2(Tree tree)
        {
            if (tree == null)
                return 0;
            int left = GetMaxDeepNodeIndex2(tree.Left) + 1;
            int right = GetMaxDeepNodeIndex2(tree.Right) + 1;
            return Math.Max(left, right);
        }
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


        public void GetMaxDeepNodeValue(Tree tree, int counter, Node result)
        {
            if (tree == null)
            {
                return;
            }
            if (tree.Left == null && tree.Right == null)
            {
                if (counter > result.Depth)
                {
                    result.Value = tree.Head;
                    result.Depth = counter;
                }
            }

            counter++;
            GetMaxDeepNodeValue(tree.Left, counter, result);
            GetMaxDeepNodeValue(tree.Right, counter, result);
        }

        public Node GetMaxDeepNodeValue2(Tree tree, int depth, Node result)
        {
            if (tree == null)
            {
                return result;
            }
            if (tree.Left == null && tree.Right == null)
            {
                return new Node() {Depth = depth, Value = result.Value};//THERE IS MISTAKE IN THIS LINE
            }

            depth++;
            var left = GetMaxDeepNodeValue2(tree.Left, depth, result);
            var right = GetMaxDeepNodeValue2(tree.Right, depth, result);

            if (left.Depth > right.Depth)
            {
                result.Value = tree.Head;
                result.Depth = depth;
                return result;
            }
            /* HERE SOME CODE IS MISSING */
            return result;
        }

    }

    public class Node
    {
        public int Depth { get; set; }
        public int Value { get; set; }
    }
}
