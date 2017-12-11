using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> headNode { get; private set; }
        public Node<T> tailNode { get; private set; }
        int count;

        public LinkedList()
        {

        }
        public LinkedList(Node<T> node)
        {
            headNode = node;
            tailNode = headNode;
            count++;
        }

        public int Length()
        {
            return count;
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

        public void Remove(T item)
        {

            if (count == 0)
            {
                return;
            }
            if (count == 1 && headNode.value.Equals(item))
            {
                headNode = null;
            }
            var currentNode = headNode;
            for (var i = 0; i < count; i++)
            {
                var temp = currentNode;
                currentNode = currentNode.nextNode;
                if (currentNode.value.Equals(item))
                {
                    temp.nextNode = currentNode.nextNode;
                    count--;
                    break;
                }

            }
            //foreach (var nodeValue in this)
            //{
            //    if (nodeValue.Equals(item))
            //    {

            //    }
            //}
        }

        public bool RemoveAt(int position)
        {
            if (position > count)
            {
                return false;
            }

            if (position == 1)
            {
                if (headNode.nextNode == null)
                {
                    headNode = null;                
                }
                else
                {
                    headNode = headNode.nextNode;
                }
                return true;
            }

            var current = headNode;
            while (position != 1)
            {
                current = current.nextNode;
                position--;
            }
            current.nextNode = current.nextNode.nextNode;
            count--;
            return true;
        }

        public T ElementAt(int position)
        {
            if (position == 1)
            {
                return headNode.value;
            }
            if (position == count)
            {
                return tailNode.value;
            }

            var current = headNode;
       
            while (position != 0)
            {
                current = current.nextNode;
                position--;
            }
            return current.value;
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
