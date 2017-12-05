using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Third
{
    class BinarryTreeMaxDeepNodeValue
    {

        public int GetMaxDeepNodeValue(Tree tree)
        {
            var lst = GetDeepNodes(tree, new List<Node>(),1);
            return  lst.OrderByDescending(x => x.Depth).Where(x => x.Depth == lst.First().Depth).ToList().Max(y=> y.Value);
        }
        private List<Node> GetDeepNodes(Tree tree, List<Node> lst, int depth)
        {
            if (tree == null)
                return lst;
            if (tree.Left == null && tree.Right == null)
            {
                lst.Add(new Node() {Value = tree.Head, Depth = depth});
            }
            depth++;
            GetDeepNodes(tree.Left, lst, depth);
            GetDeepNodes(tree.Right, lst, depth);

            return lst;
        }
    }

    public class Node
    {
        public int Depth { get; set; }
        public int Value { get; set; }
    }
}
