using LinkedListsTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTraining_tests
{
    [TestClass]
    public class MyLinkedList_tests
    {
        [TestMethod]
        public void AddAtHead_OneNumber_CanReturnNumber()
        {
            var input = 2;
            var expected = 2;
            var sut = new MyLinkedList();

            sut.AddAtHead(input);

            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtHead_ThreeNumbers_CanReturnHead()
        {
            var input = 2;
            var input2 = 4;
            var input3 = 8;

            var expected = 8;
            var sut = new MyLinkedList();

            sut.AddAtHead(input);
            sut.AddAtHead(input2);
            sut.AddAtHead(input3);


            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtHead_ThreeNumbers_CanReturnTail()
        {
            var input = 2;
            var input2 = 4;
            var input3 = 8;

            var expected = 2;
            var sut = new MyLinkedList();

            sut.AddAtHead(input);
            sut.AddAtHead(input2);
            sut.AddAtHead(input3);

            var actual = sut.Get(2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_InvalidIndex_ReturnNegativeOne()
        {
            var input = 2;
            var expected = -1;
            var sut = new MyLinkedList();

            sut.AddAtHead(input);

            var actual = sut.Get(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_EmptyLinkedList_ReturnNegativeOne()
        {
            var expected = -1;
            var sut = new MyLinkedList();

            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtTail_OneNumber_CanReturnNumber()
        {
            var input = 2;
            var expected = 2;
            var sut = new MyLinkedList();

            sut.AddAtTail(input);

            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtTail_ThreeNumbers_CanReturnHead()
        {
            var input = 2;
            var input2 = 4;
            var input3 = 8;

            var expected = 2;
            var sut = new MyLinkedList();

            sut.AddAtTail(input);
            sut.AddAtTail(input2);
            sut.AddAtTail(input3);


            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtTail_ThreeNumbers_CanReturnTail()
        {
            var input = 2;
            var input2 = 4;
            var input3 = 8;

            var expected = 8;
            var sut = new MyLinkedList();

            sut.AddAtTail(input);
            sut.AddAtTail(input2);
            sut.AddAtTail(input3);

            var actual = sut.Get(2);
            Assert.AreEqual(expected, actual);
        }
    }
}
