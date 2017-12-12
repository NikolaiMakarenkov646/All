using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Third
{
    public class BinaryTreeSerilization
    {
        private List<Tree> _lisOfTreeNode = new List<Tree>();

        public List<Tree> Serialize(Tree tree)
        {
            SerializeBinaryTree(tree);
            return _lisOfTreeNode;
        }
        private void SerializeBinaryTree(Tree root)
        {
            if (root == null)
            {
                _lisOfTreeNode.Add(new Tree());
            }
            else
            {
                _lisOfTreeNode.Add(root);
                this.SerializeBinaryTree(root.Left);
                this.SerializeBinaryTree(root.Right);
            }
        }
        public Tree DeserializeBinaryTree(List<Tree> listofNodes)
        {
            if (listofNodes.Count <= 0)
            {
                return null;
            }

            var root = listofNodes[0];
            this.DeserializeBinaryTreeRecursion(listofNodes, root);

            return root;
        }

        private int start = 0;
        private void DeserializeBinaryTreeRecursion(List<Tree> listofNodes, Tree root)
        {
            if (listofNodes[start].Head == -1)
            {
                return;
            }
            start++;

            this.DeserializeBinaryTreeRecursion(listofNodes, root.Left);
            this.DeserializeBinaryTreeRecursion(listofNodes, root.Right);
        }
    }
}
