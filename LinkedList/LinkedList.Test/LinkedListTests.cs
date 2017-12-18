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
        public void FirstTest()
        {
            var list = new LinkedList<int>();
            var res = list.Length();
            Assert.That(res, Is.EqualTo(0), "");
        }

        [Test]
        public void SecTest()
        {
            var list = new LinkedList<int>();
            list.AddEnd(new Node<int>(2));
            var res = list.Length();
            Assert.That(res, Is.EqualTo(1), "Error");
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

        static object[] Add_Success_Cases =
        {
            new int[] { 0 },
            new int[] { 0, 1 },
            new int[] { 0, 1, 2 },
            new int[] { 0, 1, 2, 3 },
        };
    }
}
