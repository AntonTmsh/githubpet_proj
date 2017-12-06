using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node<T>
    {
        public Node<T> nextNode;
        public T value;
        public Node(T value)
        {
            this.value = value;
        }
    }
}
