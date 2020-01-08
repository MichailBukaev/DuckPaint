using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    public class AVLTreeNode
    {
        int value;
        AVLTree tree = null;
        AVLTreeNode parent = null;
        AVLTreeNode left = null;
        AVLTreeNode right = null;
        public AVLTreeNode(int value, AVLTree tree, AVLTreeNode parent)
        {
            this.value = value;
            this.tree = tree;
            this.parent = parent;
        }
        public int Value { get { return value; } }

        public AVLTreeNode Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
                if (left != null)
                {
                    left.Parent = this;
                }
            }
        }
        public AVLTreeNode Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
                if (right != null)
                {
                    right.Parent = this;
                }
            }
        }
        public AVLTreeNode Parent { get { return parent; } set { parent = value; } }


        public int CompareToValue(int other)
        {
            return value.CompareTo(other);
        }

        private int MaxChildHeight(AVLTreeNode node)
        {
            if (node != null)
            {
                return 1 + Math.Max(MaxChildHeight(node.Left), MaxChildHeight(node.Right));
            }
            return 0;
        }
        private int LeftHight
        {
            get
            {
                return MaxChildHeight(left);
            }
        }

        private int RightHight
        {
            get
            {
                return MaxChildHeight(right);
            }
        }

        private TreeState State
        {
            get
            {
                if (LeftHight - RightHight > 1)
                {
                    return TreeState.LeftHeavy;
                }
                if (RightHight - LeftHight > 1)
                {
                    return TreeState.RightHeavy;
                }
                return TreeState.Balanced;
            }
        }
        public void Balance()
        {
            if (State == TreeState.RightHeavy)
            {
                if (Right != null && Right.BalanceFactor < 0)
                {
                    RightleftRotation();
                }
                else
                {
                    leftRotation();
                }
            }
            else if (State == TreeState.LeftHeavy)
            {
                if (Left != null && Left.BalanceFactor > 0)
                {
                    LeftRightRotation();
                }
                else
                {
                    RightRotation();
                }

            }
        }

        private void RightRotation()
        {
            AVLTreeNode newRoot = Left;
            ReplaceRoot(newRoot);
            Left = newRoot.Right;
            newRoot.Right = this;
        }

        private void RightleftRotation()
        {
            AVLTreeNode tmpThis = Right;
            AVLTreeNode tmpRoot = tmpThis.Left;
            Right = tmpRoot;
            tmpRoot.Parent = this;
            tmpThis.Parent = tmpRoot;
            if (tmpRoot.Right != null)
            {
                tmpRoot.Right.Parent = tmpThis;
            }
            tmpThis.Left = tmpRoot.Right;
            tmpRoot.Right = tmpThis;
            AVLTreeNode newRoot = Right;
            ReplaceRoot(newRoot);
            Right = newRoot.Left;
            newRoot.Left = this;
        }

        private void leftRotation()
        {
            AVLTreeNode newRoot = Right;
            ReplaceRoot(newRoot);
            Right = newRoot.Left;
            newRoot.Left = this;
        }

        private void LeftRightRotation()
        {
            AVLTreeNode tmpThis = Left;
            AVLTreeNode tmpRoot = tmpThis.Right;
            Left = tmpRoot;
            tmpRoot.Parent = this;
            tmpThis.Parent = tmpRoot;
            if (tmpRoot.Left != null)
            {
                tmpRoot.Left.Parent = tmpThis;
            }
            tmpThis.Right = tmpRoot.Left;
            tmpRoot.Left = tmpThis;
            AVLTreeNode newRoot = Left;
            ReplaceRoot(newRoot);
            Left = newRoot.Right;
            newRoot.Right = this;
        }

        enum TreeState
        {
            Balanced,
            LeftHeavy,
            RightHeavy,
        }
        private int BalanceFactor
        {
            get
            {
                return RightHight - LeftHight;
            }
        }

        private void ReplaceRoot(AVLTreeNode newRoot)
        {
            if (this.Parent != null)
            {
                if (this.Parent.Left == this)
                {
                    this.Parent.left = newRoot;
                }
                else if (this.Parent.Right == this)
                {
                    this.Parent.Right = newRoot;
                }
            }
            else
            {
                tree.Root = newRoot;
            }
            newRoot.Parent = this.Parent;
            this.Parent = newRoot;
        }
    }
}
