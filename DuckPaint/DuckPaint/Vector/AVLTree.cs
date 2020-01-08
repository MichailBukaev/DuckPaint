using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    public class AVLTree
    {
        private AVLTreeNode root;
        private int count = 0;


        public AVLTreeNode Root { get { return root; } set { root = value; } }
        public int Count { get { return count; } }
        public AVLTree(int value)
        {
            root = new AVLTreeNode(value, this, null);
            count++;
        }
        public AVLTree(int[] arr)
        {
            root = new AVLTreeNode(arr[0], this, null);
            count++;
            for (int i = 1; i < arr.Length; i++)
            {
                AddTo(root, arr[i]);
                count++;
            }
        }
        private void AddTo(AVLTreeNode node, int value)
        {
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new AVLTreeNode(value, this, node);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new AVLTreeNode(value, this, node);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
            node.Balance();
        }
        public IEnumerator<AVLTreeNode> GetEnumerator()
        {
            return InOrderTraversal();
        }
        private IEnumerator<AVLTreeNode> InOrderTraversal()
        {
            if (root != null)
            {
                Stack<AVLTreeNode> stack = new Stack<AVLTreeNode>();
                AVLTreeNode current = root;
                int step;
                Point point;
                bool goleftNext = true;
                stack.Push(current);
                while (stack.Count > 0)
                {
                    if (goleftNext)
                    {
                        while (current.Left != null)
                        {
                            stack.Push(current);
                            current = current.Left;
                        }
                    }
                    

                    yield return current;

                    if (current.Right != null)
                    {
                        current = current.Right;
                        goleftNext = true;
                    }
                    else
                    {
                        current = stack.Pop();
                        goleftNext = false;
                    }

                }
            }
        }

    }
}
