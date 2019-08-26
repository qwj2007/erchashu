using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="node"></param>
        public void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                node.DispalyNode();
                InOrder(node.Right);
            }
        }
        /// <summary>
        /// 前序遍历
        /// </summary>
        /// <param name="node"></param>
        public void PreOrder(Node node)
        {
            if (node != null)
            {
                node.DispalyNode();
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }
        /// <summary>
        /// 倒序
        /// </summary>
        /// <param name="node"></param>
        public void BackOrder(Node node)
        {
            if (node != null)
            {
                BackOrder(node.Right);
                node.DispalyNode();
                BackOrder(node.Left);
            }
        }
        /// <summary>
        /// 后序遍历
        /// </summary>
        /// <param name="node"></param>
        public void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                node.DispalyNode();
            }
        }
        public void Insert(int i)
        {
            Node newNode=new Node();
            newNode.Data=i;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }
    }
}
