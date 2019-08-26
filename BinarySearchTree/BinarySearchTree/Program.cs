using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rd = new Random();
            BinarySearchTree tree = new BinarySearchTree();
            Console.WriteLine("原始序列："); Console.WriteLine();
            for (int i = 0; i < 15; i++)
            {
                int t = rd.Next(100);
                tree.Insert(t);
                Console.Write(t + " ");
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("中序遍历："); Console.WriteLine();
            tree.InOrder(tree.root);
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("先序遍历："); Console.WriteLine();
            tree.PreOrder(tree.root);
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("后序遍历："); Console.WriteLine();
            tree.PostOrder(tree.root);
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("倒序遍历："); Console.WriteLine();
            tree.BackOrder(tree.root);
            Console.ReadLine();
        }
    }
}
