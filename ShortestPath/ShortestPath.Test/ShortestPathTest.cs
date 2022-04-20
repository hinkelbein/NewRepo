using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShortestPath1;

namespace ShortestPath.Test
{
    [TestClass]
    public class ShortestPathTest
    {
        public void NetworkAssignment()
        {
            SearchAlgorithm.Origin = "1";
            SearchAlgorithm.Destination = "5";
            SearchAlgorithm.MainDestination = "5";
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "1", Orig = "1", Dest = "2", Cost = 7 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "2", Orig = "1", Dest = "3", Cost = 9 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "3", Orig = "1", Dest = "6", Cost = 14 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "4", Orig = "2", Dest = "1", Cost = 7 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "5", Orig = "2", Dest = "3", Cost = 10 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "6", Orig = "2", Dest = "4", Cost = 15 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "7", Orig = "3", Dest = "1", Cost = 9 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "8", Orig = "3", Dest = "2", Cost = 10 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "9", Orig = "3", Dest = "4", Cost = 11 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "10", Orig = "3", Dest = "6", Cost = 2 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "11", Orig = "4", Dest = "2", Cost = 15 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "12", Orig = "4", Dest = "3", Cost = 11 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "13", Orig = "4", Dest = "5", Cost = 6 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "14", Orig = "5", Dest = "4", Cost = 6 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "15", Orig = "5", Dest = "6", Cost = 9 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "16", Orig = "6", Dest = "1", Cost = 14 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "17", Orig = "6", Dest = "3", Cost = 2 });
            NetworkNodes_ArcsInitialization.arcs.Add(new NetworkNodes_ArcsInitialization { Idno = "18", Orig = "6", Dest = "5", Cost = 9 });

            NetworkNodes_ArcsInitialization obj = new NetworkNodes_ArcsInitialization();
            obj.NodesBackarcAssingment();
        }
        [TestMethod]
        public void UpdateNodesPropertiesTest()
        {
            NetworkAssignment();
            SearchAlgorithm obj1 = new SearchAlgorithm();
            obj1.UpdateNodesProperties();

            Assert.AreEqual(20, NetworkNodes_ArcsInitialization.NodeCost["1"]);
            Assert.AreEqual(21, NetworkNodes_ArcsInitialization.NodeCost["2"]);

            Assert.AreEqual("3", NetworkNodes_ArcsInitialization.NodeSuccessor["1"]);
            Assert.AreEqual("4", NetworkNodes_ArcsInitialization.NodeSuccessor["2"]);
        }

        [TestMethod]
        public void ShortestPathTst()
        {
            ///<summary>
            ///  Node Cost  Successor
            ///  1      20      3
            ///  2      21      4           Path From 1 -> 5 => 1->3
            ///  3      11      6                               3->6    (1-3-6-5)
            ///  4      6       5                               6->5
            ///  5      0       null
            ///  6      9       5
            ///</summary>
            NetworkAssignment();
            SearchAlgorithm obj2 = new SearchAlgorithm();
            obj2.ShortestPath();

            List<string> path = new List<string>() { "1", "3", "6", "5" };
            Assert.AreEqual(path[0], obj2.SHPath[0]);
            Assert.AreEqual(path[1], obj2.SHPath[1]);
            Assert.AreEqual(path[2], obj2.SHPath[2]);
            Assert.AreEqual(path[3], obj2.SHPath[3]);
        }
    }
}
