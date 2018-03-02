using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>, ILinkedList<T>
    {
        public Node<T> HeadNode { get; private set; }
        public Node<T> TailNode { get; private set; }
        private int _count;

        public int Length()
        {
            return _count;
        }

        public void AddEnd(Node<T> node)
        {
            if (_count == 0)
            {
                HeadNode = node;
            }
            else
            {
                TailNode.NextNode = node;
            }
            TailNode = node;
            _count++;
        }

        public void Add(T item)
        {
            AddFirst(new Node<T>(item));
        }

        public void AddFirst(Node<T> node)
        {
            var temp = HeadNode;
            HeadNode = node;
            if (_count == 0)
            {
                TailNode = HeadNode;
            }
            else
            {
                HeadNode.NextNode = temp;
            }
            _count++;
        }

        public void AddAt(T item, int position)
        {
            AddAt(new Node<T>(item), position);
        }

        public void AddAt(Node<T> node, int position)
        {
            if (position > _count || position < 0)
            {
                return;
            }
            var current = HeadNode;
            while (position != 1)
            {
                current = current.NextNode;
                position--;
            }
            var temp = current.NextNode;
            current.NextNode = node;
            node.NextNode = temp;
            _count++;
        }

        public bool Remove(T item)
        {

            if (_count == 0)
            {
                return false;
            }
            if (_count == 1 && HeadNode.Value.Equals(item))
            {
                HeadNode = null;
                TailNode = null;
                _count--;
                return true;
            }
            var currentNode = HeadNode;
            for (var i = 0; i < _count; i++)
            {
                var temp = currentNode;
                currentNode = currentNode.NextNode;
                if (currentNode.Value.Equals(item))
                {
                    temp.NextNode = currentNode.NextNode;
                    _count--;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveAt(int position)
        {
            if (position > _count || position < 0)
            {
                return false;
            }
            if (_count == 0)
            {
                return false;
            }

            if (position == 0)
            {
                if (TailNode.NextNode == null)
                {
                    TailNode = null;
                    HeadNode = null;
                }
                else
                {
                    TailNode = TailNode.NextNode;
                }
                _count--;
                return true;
            }

            var current = HeadNode;
            while (position != 0)
            {
                current = current.NextNode;
                position--;
            }
            current.NextNode = current.NextNode.NextNode;
            _count--;
            return true;
        }

        public T ElementAt(int position)
        {
            if (position == 1)
            {
                return HeadNode.Value;
            }
            if (position == _count)
            {
                return TailNode.Value;
            }

            var current = HeadNode;
       
            while (position != 0)
            {
                current = current.NextNode;
                position--;
            }
            return current.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = HeadNode;
            while (current != null)
            {
                yield return current.Value;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }
    }
}
