using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    class Node
    {
        private Node nextNode, previousNode;
        private string content;

        public Node()
        {
        }

        public Node(Node previousNode, string content, Node nextNode)
        {
            this.NextNode = nextNode;
            this.PreviousNode = previousNode;
            this.Content = content;
        }

        public Node NextNode { get => nextNode; set => nextNode = value; }
        public Node PreviousNode { get => previousNode; set => previousNode = value; }
        public string Content { get => content; set => content = value; }
    }
}
