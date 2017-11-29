using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    interface ILinkedList
    {
        int Length();
        void Add<T>(T item);
        void AddAt<T>(T item, int position);
        void Remove<T>(T item);
        void RemoveAt(int position);
        T ElementAt<T>(int position);
    }
}
