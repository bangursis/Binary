using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    class BinaryTree
    {
        Node root;

        public void Insert(int value)
        {
            this.Insert(root, value);
        }

        public void Insert(IList<int> collection)
        {
            foreach (int item in collection)
            {
                this.Insert(item);
            }
        }

        public Node Search(int value)
        {
            return Search(value, root);
        }

        
        private Node Search(int value, Node startNode)
        {
            if (startNode.value == value)
            {
                return startNode;
            }
            else
            {
                if (startNode.value > value)
                {
                    return Search(value, startNode.leftNode);
                }
                else if (startNode.value < value)
                {
                    return Search(value, startNode.rightNode);
                }
                else
                {
                    throw new Exception("The value does not exist in the tree");
                }
            }
        }

        private int Insert(Node startNode, int value)
        {
            Node node;

            if (this.root == null)
            {
                this.root = new Node(value);
                return value;
            }
            
            if (isLeftNode(startNode, value))
            {
                node = startNode.leftNode;
            }
            else
            {
                node = startNode.rightNode;
            }


            if (node != null)
            {
                return this.Insert(node, value);
            }
            else
            {
                if (isLeftNode(startNode, value))
                {
                    startNode.leftNode = new Node(value);
                }
                else
                {
                    startNode.rightNode = new Node(value);
                }

                return value;
            }
        }

        private bool isLeftNode(Node node, int value)
        {
            return node.value > value;
        }
    }
}
