using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    class LinkedList
    {
        private Node headNode;
        private Node tailNode;
        private int size = 0;



        public LinkedList()
        {
            
        }

        public List<Node> GetNodes()
        {
            List<Node> tempNodes = new List<Node>();
            tempNodes.Clear();

            Node runner = headNode;

            for(int i = 0; i < size; i++)
            {
                tempNodes.Add(runner);

                runner = runner.NextNode;
            }

            return tempNodes;
        }
        
        public List<Node> GetNodesBackwards()
        {
            List<Node> tempNodes = new List<Node>();

            Node runner = tailNode;

            for(int i = 0; i < size; i++)
            {
                tempNodes.Add(runner);

                runner = runner.PreviousNode;
            }

            return tempNodes;
        }


        public void Append(string content)
        {
            if (size == 0)
            {
                SetTailHead(content);
            }
            else
            {
                Node newNode = new Node(tailNode, content, headNode);
                tailNode.NextNode = newNode;//Since the new incoming node is our tail node, this will need to point to our new node
                tailNode = newNode;//the new node is the tail now
            }
            size++;
        }
        //public void AppendGn(T content)
        //    {
        //        if (size == 0)
        //        {
        //            SetTailHead(content);
        //        }
        //        else
        //        {
        //            Node newNode = new Node(tailNode, content, headNode);
        //            tailNode.NextNode = newNode;//Since the new incoming node is our tail node, this will need to point to our new node
        //            tailNode = newNode;//the new node is the tail now
        //        }
        //        size++;
        //    }

        
        public void Prepend(string content)//To prepend list i will need to redefine the head 
        {
            if (size == 0)
            {
                SetTailHead(content);
            }
            else
            {
                Node newNode = new Node(tailNode, content, headNode);
                headNode.PreviousNode = newNode;// dot.Previous for our head node will need to point to the new node(which is now our head node)
                headNode = newNode;//the head node will be this new node
                
            }
            size++;
        }

        public Boolean MiddleInsert(Node midNode, int position)
        {

            if (position <= 1)                                                                                                      //This will be the head + to -infinity 
            {
                                                                                                                                //this is the head
                return false;
            }
            else if(position-1 > size)                                                                                                      //This will be the tail to infinity
            {
                                                                                                                                        //this is the 
                return false;
            }

            Node runner = headNode;
            Node beforeNode = null;
            Node afterNode = null;

            for (int i = 2; i <= position; i++)                                                                                         //Loop until we get to position +1(so we have the afterNode)
            {                                                                                                                   //We start at 2 cause 1 is already the head and not 0 cause this is not an array
                runner = runner.NextNode;

                if (position-1 == i)
                {
                    beforeNode = runner;
                }

                afterNode = runner;
            }

            midNode.PreviousNode = beforeNode;
            midNode.NextNode = afterNode;

            beforeNode.NextNode = midNode;
            afterNode.PreviousNode = midNode;
            size++;

            return true;
        }


        public void Delete(int position)
        {
            Node runner = headNode;
            Node afterNode = null;
            Node beforeNode = null;

            for (int i = 2; i <= position+1; i++)//2 cause 1 is the head, +1 so we get the following node
            {
                runner = runner.NextNode;

                if (i == position-1)
                {
                    beforeNode = runner;
                }

                if(i == position)
                {
                    //This is the delete node
                }

                afterNode = runner;
            }

            afterNode.PreviousNode = beforeNode;
            beforeNode.NextNode = afterNode;//Getting an error here cause there is no before node, the before node is the tail. this only applies for index 0. to fix this use an if statement.

            size--;
        }

        private void SetTailHead(string content)
        {
            Node newHeadTail = new Node(null, content, null);
            headNode = newHeadTail;
            tailNode = newHeadTail;
        }
    }
}
