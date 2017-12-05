using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Third
{
    public class BinarryTreeAllPaths
    {
        public List<List<int>> GetAllPaths(Tree binaryTree)
        {
            var result = new List<List<int>>();

            CreatePaths(binaryTree, new List<int>(), result);

            return result;
        }

        private void CreatePaths(Tree binaryTree, List<int> pathList, List<List<int>> result)
        {
            if (binaryTree == null)
                return;

            pathList.Add(binaryTree.Head);
            if (binaryTree.Left == null && binaryTree.Right == null)
            {
                result.Add(pathList);
            }

            CreatePaths(binaryTree.Left, CreateNewCloneList(pathList), result);
            CreatePaths(binaryTree.Right, CreateNewCloneList(pathList), result);
        }


        private List<int> CreateNewCloneList(List<int> pathList)
        {
            List<int> lst = new List<int>();
            lst.AddRange(pathList);
            return lst;
        }
    }
}
