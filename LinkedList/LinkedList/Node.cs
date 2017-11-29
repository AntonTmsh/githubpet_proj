using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node<T>
    {
        private Node<T> _nextNode;
        private T _value;
        public Node(T value)
        {
            _value = value;
        }
    }
}
