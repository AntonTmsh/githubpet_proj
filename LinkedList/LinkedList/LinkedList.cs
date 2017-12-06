using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T>
    {
        public Node<T> headNode;
        public Node<T> tailNode;
        public int count;

        public LinkedList()
        {

        }
        public LinkedList(Node<T> node)
        {
            headNode = node;
            tailNode = headNode;
            count++;
        }

        public void Add(Node<T> node)
        {
            if (headNode == tailNode)
            {
                tailNode = node;
                headNode.nextNode = tailNode;
            }
            Node<T> temp = tailNode;
            tailNode = node;
            temp.nextNode = tailNode;
            count++;
        }

        public void AddEnd(Node<T> node)
        {
            if (count == 0)
            {
                headNode = node;
            }
            else
            {
                tailNode.nextNode = node;
            }
            tailNode = node;
            count++;
        }
    }
}
