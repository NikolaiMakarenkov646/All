using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Third
{
    public class BinarryTreeMaxNumber
    {

        public int GetMaxNumber(Tree tree)
        {
            if (tree == null)
                return int.MinValue;

            int result = tree.Head;
            int resultLeft = GetMaxNumber(tree.Left);
            int resultRight = GetMaxNumber(tree.Right);

            if (resultLeft > result)
                result = resultLeft;
            if (resultRight > result)
                result = resultRight;
            return result;
        }
    }
}
