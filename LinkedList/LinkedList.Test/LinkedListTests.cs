using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LinkedList.Test
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void test1()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Assert.AreEqual(4, list.Length());
        }

        [Test, TestCaseSource("Add_Success_Cases")]
        public void Add_Raw_Value_Success_Cases(int[] testCase)
        {
            LinkedList<int> list = new LinkedList<int>();
            foreach (int value in testCase)
            {
                list.Add(value);
            }

            Assert.AreEqual(testCase.Length, list.Length(),
                "There was an unexpected number of list items");

            Assert.AreEqual(testCase.Last(), list.HeadNode.Value,
                "The first item value was incorrect");

            Assert.AreEqual(testCase.First(), list.TailNode.Value,
                "The last item value was incorrect");

            int[] reversed = testCase.Reverse().ToArray();
            int current = 0;

            foreach (int value in list)
            {
                Assert.AreEqual(reversed[current], value, "The list value at index {0} was incorrect.", current);
                current++;
            }
        }

        //[Test]
        //public void RemoveFirstPosition_Empty_Lists()
        //{
        //    LinkedList<int> list = new LinkedList<int>();
        //    Assert.AreEqual(0, list.Length());
        //    Assert.IsNull(list.HeadNode);
        //    Assert.IsNull(list.TailNode);

        //    list.RemoveAt(0);
        //    Assert.AreEqual(0, list.Length());
        //    Assert.IsNull(list.HeadNode);
        //    Assert.IsNull(list.TailNode);

        //}

        //[Test]
        //public void RemoveFirst_One_Node()
        //{
        //    LinkedList<int> list = new LinkedList<int>();

        //    list.Add(1);
        //    list.RemoveAt(0);
        //    Assert.AreEqual(0, list.Length());
        //    Assert.IsNull(list.HeadNode);
        //    Assert.IsNull(list.TailNode);

        //    list.Add(2);
        //    list.Remove(2);
        //    Assert.AreEqual(0, list.Length());
        //    Assert.IsNull(list.HeadNode);
        //    Assert.IsNull(list.TailNode);
        //}

        //[Test]
        //public void RemoveFirstLast_Two_Node()
        //{
        //    LinkedList<int> list = new LinkedList<int>();

        //    list.AddFirst(10);
        //    list.AddFirst(20);

        //    list.RemoveFirst();
        //    Assert.AreEqual(1, list.Count);
        //    Assert.AreEqual(10, list.Head.Value);
        //    Assert.AreEqual(10, list.Tail.Value);

        //    list.AddFirst(10);
        //    list.RemoveLast();
        //    Assert.AreEqual(1, list.Count);
        //    Assert.AreEqual(10, list.Head.Value);
        //    Assert.AreEqual(10, list.Tail.Value);
        //}

        static object[] Add_Success_Cases =
        {
            new int[] { 0 },
            new int[] { 0, 1 },
            new int[] { 0, 1, 2 },
            new int[] { 0, 1, 2, 3 },
        };
    }
}
