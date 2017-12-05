using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Third
{
    public class BinarryTreeAllPathsEfficient
    {

        public int GetMaxCountDistinct(Tree binaryTree)
        {
            var result = CreatePaths(binaryTree, new List<int>(), 0);
            return result;
        }

        private int CreatePaths(Tree binaryTree, List<int> pathList, int result)
        {
            if (binaryTree == null)
                return 0;

            pathList.Add(binaryTree.Head);
            if (binaryTree.Left == null && binaryTree.Right == null)
            {
                var tmp = pathList.Distinct().Count();
                if (tmp > result)
                    result = tmp;
                return result;
            }

            var left = CreatePaths(binaryTree.Left, CreateNewCloneList(pathList), result);
            var right = CreatePaths(binaryTree.Right, CreateNewCloneList(pathList), result);

            return Math.Max(left, right);
        }


        private List<int> CreateNewCloneList(List<int> pathList)
        {
            List<int> lst = new List<int>();
            lst.AddRange(pathList);
            return lst;
        }
    }
}
