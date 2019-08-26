using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public void DispalyNode()
        {
            Console.Write( Data + " ");
        }
    }
}
