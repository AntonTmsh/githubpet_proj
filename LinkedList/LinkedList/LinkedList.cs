using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    class LinkedList<T> : IEnumerable<T>
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

        public void AddFirst(Node<T> node)
        {

            var temp = headNode;
            headNode = node;
            if (count == 0)
            {
                tailNode = headNode;
            }
            else
            {
                headNode.nextNode = temp;
            }
            count++;
        }

        public void AddAt(Node<T> node, int position)
        {
            if (position > count)
            {
                return;
            }          
            var current = headNode;
            while (position != 1)
            {
                current = current.nextNode;
                position--;
            }
            var temp = current.nextNode;
            current.nextNode = node;
            node.nextNode = temp;
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = headNode;
            while (current != null)
            {
                yield return current.value;
                current = current.nextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
