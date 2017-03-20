using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace UnitTestAlgorithms
{
    [TestClass]
    public class LinkedList_Nodes_UnitTests
    {
        [TestMethod]
        public void Node_New_Test()
        {
            // Arrange
            Node testNode = new Node(4);

            // Assert
            Assert.AreEqual(4, testNode.Data);
        }
        [TestMethod]
        public void LinkedList_AddFourToEnd_Test()
        {
            // Arrange
            LinkedList testList = new LinkedList();
            Node testNode1 = new Node(4);
            Node testNode2 = new Node(8);
            Node testNode3 = new Node(12);
            Node testNode4 = new Node(16);

            // Act
            testList.AddNodeToEnd(testNode1);
            testList.AddNodeToEnd(testNode2);
            testList.AddNodeToEnd(testNode3);
            testList.AddNodeToEnd(testNode4);

            // Assert
            Assert.AreEqual(4, testList.Count);
            Assert.AreEqual(16, testList.Last.Data);
            Assert.AreEqual(4, testList.Head.Data);
            Assert.AreEqual(testNode2, testList.Head.Next);
            Assert.AreEqual(null, testList.Last.Next);
        }
        [TestMethod]
        public void LinkedList_AddToFront_Test()
        {
            // Arrange
            LinkedList testList = new LinkedList();
            Node testNode1 = new Node(4);
            Node testNode2 = new Node(8);
            Node testNode3 = new Node(2);

            // Act
            testList.AddNodeToEnd(testNode1);
            testList.AddNodeToEnd(testNode2);
            testList.AddNodeToHead(testNode3);

            // Assert
            Assert.AreEqual(3, testList.Count);
            Assert.AreEqual(testNode3, testList.Head);
        }
        [TestMethod]
        public void LinkedList_RemoveDuplicates_Test()
        {
            // Arrange
            LinkedList testList = new LinkedList();
            Node testNode1 = new Node(4);
            Node testNode2 = new Node(8);
            Node testNode3 = new Node(4);
            Node testNode4 = new Node(16);

            testList.AddNodeToEnd(testNode1);
            testList.AddNodeToEnd(testNode2);
            testList.AddNodeToEnd(testNode3);
            testList.AddNodeToEnd(testNode4);

            // Act
            testList.RemoveDuplicateNodes();
            Node actualNext = testList.Head.Next.Next;

            // Assert
            Assert.AreEqual(3, testList.Count);
            Assert.AreEqual(testNode4, actualNext);
            Assert.AreEqual(4, testList.Head.Data);
            Assert.AreNotEqual(4, testList.Head.Next.Data);
            Assert.AreNotEqual(4, testList.Head.Next.Next.Data);
            Assert.AreEqual(null, testList.Head.Next.Next.Next);
            Assert.AreEqual(testNode4, testList.Last);
        }
        [TestMethod]
        public void LinkedList_RemoveDuplicates_Multiple_Last_Test()
        {
            // Arrange
            LinkedList testList = new LinkedList();
            Node testNode1 = new Node(4);
            Node testNode2 = new Node(8);
            Node testNode3 = new Node(12);
            Node testNode4 = new Node(8);
            Node testNode5 = new Node(4);

            testList.AddNodeToEnd(testNode1);
            testList.AddNodeToEnd(testNode2);
            testList.AddNodeToEnd(testNode3);
            testList.AddNodeToEnd(testNode4);
            testList.AddNodeToEnd(testNode5);

            // Act
            testList.RemoveDuplicateNodes();

            // Assert
            Assert.AreEqual(3, testList.Count);
            Assert.AreEqual(testNode3, testList.Last);
            Assert.AreEqual(testNode1, testList.Head);
        }
        [TestMethod]
        public void LinkedList_DeleteNode_Test()
        {
            // Arrange
            LinkedList testList = new LinkedList();
            Node testNode1 = new Node(4);
            Node testNode2 = new Node(8);
            Node testNode3 = new Node(12);
            Node testNode4 = new Node(8);
            Node testNode5 = new Node(4);

            testList.AddNodeToEnd(testNode1);
            testList.AddNodeToEnd(testNode2);
            testList.AddNodeToEnd(testNode3);
            testList.AddNodeToEnd(testNode4);
            testList.AddNodeToEnd(testNode5);

            // Act
            testList.DeleteNode(testNode3);
            Node actualNext = testList.Head.Next.Next;

            // Assert
            Assert.AreEqual(4, testList.Count);
            Assert.AreEqual(testNode5, testList.Last);
            Assert.AreEqual(testNode4, actualNext);
        }
        [TestMethod]
        public void LinkedList_DeleteNode_Last_Test()
        {
            // Arrange
            LinkedList testList = new LinkedList();
            Node testNode1 = new Node(4);
            Node testNode2 = new Node(8);
            Node testNode3 = new Node(12);
            Node testNode4 = new Node(8);
            Node testNode5 = new Node(4);

            testList.AddNodeToEnd(testNode1);
            testList.AddNodeToEnd(testNode2);
            testList.AddNodeToEnd(testNode3);
            testList.AddNodeToEnd(testNode4);
            testList.AddNodeToEnd(testNode5);

            // Act
            testList.DeleteNode(testNode5);
            Node actualNext = testList.Head.Next.Next.Next.Next;

            // Assert
            Assert.AreEqual(4, testList.Count);
            Assert.AreEqual(testNode4, testList.Last);
            Assert.AreEqual(null, actualNext);
        }
        [TestMethod]
        public void LinkedList_DeleteNode_First_Test()
        {
            // Arrange
            LinkedList testList = new LinkedList();
            Node testNode1 = new Node(4);
            Node testNode2 = new Node(8);
            Node testNode3 = new Node(12);
            Node testNode4 = new Node(8);
            Node testNode5 = new Node(4);

            testList.AddNodeToEnd(testNode1);
            testList.AddNodeToEnd(testNode2);
            testList.AddNodeToEnd(testNode3);
            testList.AddNodeToEnd(testNode4);
            testList.AddNodeToEnd(testNode5);

            // Act
            testList.DeleteNode(testNode1);
            Node actualNext = testList.Head.Next;

            // Assert
            Assert.AreEqual(4, testList.Count);
            Assert.AreEqual(testNode2, testList.Head);
            Assert.AreEqual(testNode3, actualNext);
        }
    }
}
