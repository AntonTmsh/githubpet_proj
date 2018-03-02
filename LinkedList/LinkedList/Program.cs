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

            int test1 = 5;
            var test = test1.Equals(5);


            //var linkList = new LinkedList<int>(new Node<int>(2));
            var linkList1 = new LinkedList<int>();
            linkList1.Add(1);
            linkList1.Add(2);
            linkList1.Add(3);
            linkList1.Add(4);

            var linkList = new LinkedList<int>();
            linkList.AddEnd(new Node<int>(4));
            linkList.AddEnd(new Node<int>(8));
            linkList.AddEnd(new Node<int>(9));
            linkList.AddEnd(new Node<int>(1));

            linkList.AddAt(new Node<int>(7), 2);

            foreach (var value in linkList)
            {
                Console.WriteLine("Node " + value);
            }

            var node = linkList.HeadNode;
            for (int i=0; i < linkList.Length(); i++)
            {
                
                Console.WriteLine("Node "+ node.Value);
                node = node.NextNode;

            }
        }
    }
}
