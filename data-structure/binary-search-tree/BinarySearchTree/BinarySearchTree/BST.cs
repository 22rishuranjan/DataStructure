using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BST
    {
        public Node root;

        #region Insertion

        public Node Insert(Node node, int key)
        {
            if (node == null)
            {
                return new Node(key);
            }
            if (key > node.Key)
            {
                node.Right = Insert(node.Right, key);
            }
            if (key < node.Key)
            {
                node.Left = Insert(node.Left, key);
            }

            return node;

        }

        public void Insert(int key)
        {
            root = Insert(root, key);

        }

        #endregion

        #region Traversal

        #region Pre-Order Travesal
        public void PreOrder()
        {
            Console.Write("\nPreOrder Traversal: ");

            PreOrder(root);
        }

        private void PreOrder(Node node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.Key + ",");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }
        #endregion

        #region In-Order Traversal

        public void InOrder()
        {
            Console.Write("\nInOrder Traversal :");

            InOrder(root);
        }

        private void InOrder(Node node)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.Left);
            Console.Write(node.Key + ",");
            InOrder(node.Right);
        }

        #endregion

        #region Post-Order Traversal

        public void PostOrder()
        {
            Console.Write("\nPostOrder Traversal :");

            PostOrder(root);
        }

        public void PostOrder(Node node)
        {
            if (node == null)
            {
                return;
            }

            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Key + ",");
        }

        #endregion

        #endregion


        #region Search

        public Node Search(int key)
        {
            return Search(root, key);
        }

        private Node Search(Node node, int key)
        {
            if(node == null || node.Key == key)
            {
                return node;
            }

            if(key > node.Key)
            {
                return Search(node.Right, key);
            }

            if(key < node.Key)
            {
                return Search(node.Left, key);
            }

            return node;

        }

        #endregion


        #region GetHeight


        public int GetHeight()
        {
            return GetHeight(root);
        }

        private int GetHeight(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftHeight = GetHeight(node.Left);
            int rightHeight = GetHeight(node.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        #endregion
    }
}
