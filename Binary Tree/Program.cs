using System;
using System.Collections.Generic;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            List<int> list = new List<int>() { 5, 7, 9, 2, 3, 1, 10, 4 };

            binaryTree.Insert(list);

            Node node = binaryTree.Search(3);

            binaryTree.Print();

            Console.WriteLine(node.rightNode.value);
        }
    }
}
