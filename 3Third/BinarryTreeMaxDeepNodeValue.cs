using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Third
{
    class BinarryTreeMaxDeepNodeValue
    {
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
    }

    public class Node
    {
        public int Depth { get; set; }
        public int Value { get; set; }
    }
}
