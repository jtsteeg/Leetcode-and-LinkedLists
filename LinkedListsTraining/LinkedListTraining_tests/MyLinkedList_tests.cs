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

        [TestMethod]
        public void AddAtIndex_AddAtIndexOne_CanReturnNewNumber()
        {
            var index = 1;
            var input = 6;
            var expected = 6;
            var sut = new MyLinkedList();

            sut.AddAtHead(8);
            sut.AddAtHead(4);
            sut.AddAtHead(2);
            sut.AddAtIndex(index, input);


            var actual = sut.Get(index);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtIndex_AddAtHeadIndex_UpdatesHead()
        {
            var index = 0;
            var input = 6;
            var expected = 6;
            var sut = new MyLinkedList();

            sut.AddAtHead(8);
            sut.AddAtHead(4);
            sut.AddAtHead(2);
            sut.AddAtIndex(index, input);


            var actual = sut.Get(index);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtIndex_AddToEmptyLinkedList_UpdatesHead()
        {
            var index = 0;
            var input = 6;
            var expected = 6;
            var sut = new MyLinkedList();

            sut.AddAtIndex(index, input);


            var actual = sut.Get(index);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtIndex_AddAtTailIndex_UpdatesTail()
        {
            var index = 5;
            var input = 6;


            var expected = 6;
            var sut = new MyLinkedList();

            sut.AddAtHead(8);
            sut.AddAtHead(4);
            sut.AddAtHead(2);
            sut.AddAtHead(2);
            sut.AddAtHead(2);
            sut.AddAtHead(2);
            sut.AddAtIndex(index, input);


            var actual = sut.Get(index);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtIndex_AddAtInvalidIndex_NoChange()
        {
            var index = 5;
            var input = 6;
            var expected = 8;
            var sut = new MyLinkedList();

            sut.AddAtHead(8);
            sut.AddAtHead(4);
            sut.AddAtHead(2);
            sut.AddAtIndex(index, input);


            var actual = sut.Get(2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAtIndex_DeleteMiddleIndex_NextIndexIsNowMiddle()
        {
            var index = 1;
            var expected = 8;
            var sut = new MyLinkedList();

            sut.AddAtHead(8);
            sut.AddAtHead(4);
            sut.AddAtHead(2);
            sut.DeleteAtIndex(index);


            var actual = sut.Get(index);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAtIndex_DeleteHead_SecondIndexIsNowHead()
        {
            var index = 0;
            var expected = 4;
            var sut = new MyLinkedList();

            sut.AddAtHead(8);
            sut.AddAtHead(4);
            sut.AddAtHead(2);
            sut.DeleteAtIndex(index);


            var actual = sut.Get(index);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAtIndex_DeleteTail_ReturnNegativeOne()
        {
            var index = 2;
            var expected = -1;
            var sut = new MyLinkedList();

            sut.AddAtHead(8);
            sut.AddAtHead(4);
            sut.AddAtHead(2);
            sut.DeleteAtIndex(index);


            var actual = sut.Get(index);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAtIndex_DeleteInvalidIndex_TailValueNoChange()
        {
            var index = 12;
            var expected = 8;
            var sut = new MyLinkedList();

            sut.AddAtHead(8);
            sut.AddAtHead(4);
            sut.AddAtHead(2);
            sut.DeleteAtIndex(index);


            var actual = sut.Get(2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAtIndex_DeleteFromEmptyLinkedList_LinkedListRemainsEmpty()
        {
            var index = 1;
            var expected = -1;
            var sut = new MyLinkedList();

            sut.DeleteAtIndex(index);


            var actual = sut.Get(index);
            Assert.AreEqual(expected, actual);
        }
    }
}
