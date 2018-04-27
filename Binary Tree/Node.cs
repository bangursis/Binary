using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree
{
    class Node
    {
        public int value { get; set; }
        public Node rightNode { get; set; }
        public Node leftNode { get; set; }
        
        public Node(int value)
        {
            this.value = value;
        }
    }
}
