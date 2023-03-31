using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLabD
{
    internal class LinkedList
    {
        public Node Head { get; set; }

        public int Count { get; set; }

        public LinkedList() 
        { 
            this.Head = null;
        }

        public void AddFirst(string value)
        {
            // Create new node
            Node node = new Node();
            // Assign value to new node
            node.Value = value;
            // Create variable(old head node) and assign node at head
            Node oldHeadNode = this.Head;
            // Assign head to new node
            this.Head = node;
            // Assign next to old head node
            node.Next = oldHeadNode;
            // Increment Count
            Count++;
        }

        public void AddLast(string value)
        {
            // Create new node
            Node node = new Node();
            node.Value = value;
            
            if (this.Head == null)
            {
                this.Head = node;
            } else
            {
                Node newNode = this.Head;
                while(newNode.Next != null)
                {
                    newNode = newNode.Next;
                }
                newNode.Next = node;

            }
            // Increment Count
            Count++;
        }

        public void RemoveFirst()
        {
            if (this.Head != null)
            {
                this.Head = this.Head.Next;
            } else
            {
                throw new Exception() { };
            }
            Count--;
        }

        public void RemoveLast()
        {
            if (this.Head != null)
            {
                if(this.Head.Next == null)
                {
                    this.Head = null;
                } else
                {
                    Node newNode = this.Head;
                    while(newNode.Next != null && newNode.Next.Next != null)
                    {
                        newNode = newNode.Next;
                    }
                    newNode.Next = null;
                }
            } else
            {
                throw new Exception() { };
            }
            Count--;
        }
        public string GetValue(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new Exception();
            }
            //Loop until you reach the node at that index
            //And then return the value
            //Make sure to return the value, not the node itself.
            Node node = this.Head;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }
            return node.Value;
        }
    }
}
