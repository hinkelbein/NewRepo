﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShortestPath.Test
{
    [TestClass]
    public class ShortestPath_Heap_Test
    {
        Dictionary<string, Node> nodes = new Dictionary<string, Node>();
        public void Input()
        {
            nodes.Add("1", new Node("1", 11, "a"));
            nodes.Add("2", new Node("2", 10, "b"));
            nodes.Add("3", new Node("3", 2, "c"));
            nodes.Add("4", new Node("4", 14, "d"));
        }
        [TestMethod]
        public void Heap_Constructor_Test()
        {
            Input();
            Heap heap = new Heap(nodes);
            Assert.IsNotNull(heap);
        }
        [TestMethod]
        public void Heap_Add_Test()
        {
            Input();
            Heap heap = new Heap(nodes);
            Assert.AreEqual("3", Heap.root.ID);
            Assert.AreEqual(2, Heap.root.Cost);

        }
        [TestMethod]
        public void Heap_Remove_Test()
        {
            Input();
            Heap heap = new Heap(nodes);
            Heap.Remove();
            Assert.AreEqual("2", Heap.root.ID);
        }

    }
}
