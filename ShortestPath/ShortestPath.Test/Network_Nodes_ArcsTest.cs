using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShortestPath1;

namespace ShortestPath.Test
{
    [TestClass]
    public class Network_Nodes_ArcsTest
    {
        [TestMethod]
        public void NodesBackarcAssingmentTest()
        {
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "1", Orig = "a", Dest = "b", Cost = 1 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "2", Orig = "c", Dest = "b", Cost = 2 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "3", Orig = "d", Dest = "c", Cost = 3 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "4", Orig = "f", Dest = "d", Cost = 4 });
            NetworkNodes_ArcsInitialization obj = new NetworkNodes_ArcsInitialization();
            obj.NodesBackarcAssingment();
            Assert.AreEqual(3, NetworkNodes_ArcsInitialization.BackArcs.Count);
            Assert.AreEqual(4, NetworkNodes_ArcsInitialization.NodeCost.Count);
            Assert.AreEqual(4, NetworkNodes_ArcsInitialization.NodeSuccessor.Count);
            Assert.IsNotNull(NetworkNodes_ArcsInitialization.BackArcs);
        }
        [TestMethod]
        public void NodesInitialization()
        {
            NetworkNodes_ArcsInitialization obj = new NetworkNodes_ArcsInitialization();
            string node = "1";
            obj.NodesInitialization(node);
            Assert.AreEqual(" ", NetworkNodes_ArcsInitialization.NodeSuccessor["1"]);
            Assert.AreEqual(double.PositiveInfinity, NetworkNodes_ArcsInitialization.NodeCost["1"]);
            Assert.IsNotNull(NetworkNodes_ArcsInitialization.NodeCost);
            Assert.IsNotNull(NetworkNodes_ArcsInitialization.NodeSuccessor);
        }
    }
}