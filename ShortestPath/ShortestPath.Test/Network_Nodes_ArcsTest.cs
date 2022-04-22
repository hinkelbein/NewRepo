//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using ShortestPath1;

//namespace ShortestPath.Test
//{
//    [TestClass]
//    public class Network_Nodes_ArcsTest
//    {
//        [TestMethod]
//        public void NodesBackarcAssingmentTest()
//        {
//            Arc.arcs.Add(new Arc { Idno = "1", Orig = "a", Dest = "b", Cost = 1 });
//            Arc.arcs.Add(new Arc { Idno = "2", Orig = "c", Dest = "b", Cost = 2 });
//            Arc.arcs.Add(new Arc { Idno = "3", Orig = "d", Dest = "c", Cost = 3 });
//            Arc.arcs.Add(new Arc { Idno = "4", Orig = "f", Dest = "d", Cost = 4 });
//            Arc obj = new Arc();
//            obj.NodesBackarcAssingment();
//            Assert.AreEqual(3, Arc.BackArcs.Count);
//            Assert.AreEqual(5, Arc.NodeCost.Count);
//            Assert.AreEqual(5, Arc.NodeSuccessor.Count);
//            Assert.IsNotNull(Arc.BackArcs);
//        }
//        [TestMethod]
//        public void NodesInitialization()
//        {
//            Arc obj = new Arc();
//            string node = "1";
//            obj.NodesInitialization(node);
//            Assert.AreEqual(" ", Arc.NodeSuccessor["1"]);
//            Assert.AreEqual(double.PositiveInfinity, Arc.NodeCost["1"]);
//            Assert.IsNotNull(Arc.NodeCost);
//            Assert.IsNotNull(Arc.NodeSuccessor);
//        }
//    }
//}