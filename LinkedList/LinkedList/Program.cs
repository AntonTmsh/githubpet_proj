using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //var linkList = new LinkedList<int>(new Node<int>(2));
            var linkList = new LinkedList<int>();
            linkList.AddEnd(new Node<int>(4));
            linkList.AddEnd(new Node<int>(8));
            linkList.AddEnd(new Node<int>(9));
            linkList.AddEnd(new Node<int>(1));


            var node = linkList.headNode;
            for (int i=0; i < linkList.count; i++)
            {
                
                Console.WriteLine("Node "+ node.value);
                node = node.nextNode;

            }
        }
    }
}
