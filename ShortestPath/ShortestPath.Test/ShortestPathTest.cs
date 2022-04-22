//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using ShortestPath1;

//namespace ShortestPath.Test
//{
//    [TestClass]
//    public class ShortestPathTest
//    {
//        public void NetworkAssignment()
//        {
//            SearchAlgorithm.Origin = "1";
//            SearchAlgorithm.Destination = "5";
//            SearchAlgorithm.MainDestination = "5";
//            Arc.arcs.Add(new Arc { Idno = "1", Orig = "1", Dest = "2", Cost = 7 });
//            Arc.arcs.Add(new Arc { Idno = "2", Orig = "1", Dest = "3", Cost = 9 });
//            Arc.arcs.Add(new Arc { Idno = "3", Orig = "1", Dest = "6", Cost = 14 });
//            Arc.arcs.Add(new Arc { Idno = "4", Orig = "2", Dest = "1", Cost = 7 });
//            Arc.arcs.Add(new Arc { Idno = "5", Orig = "2", Dest = "3", Cost = 10 });
//            Arc.arcs.Add(new Arc { Idno = "6", Orig = "2", Dest = "4", Cost = 15 });
//            Arc.arcs.Add(new Arc { Idno = "7", Orig = "3", Dest = "1", Cost = 9 });
//            Arc.arcs.Add(new Arc { Idno = "8", Orig = "3", Dest = "2", Cost = 10 });
//            Arc.arcs.Add(new Arc { Idno = "9", Orig = "3", Dest = "4", Cost = 11 });
//            Arc.arcs.Add(new Arc { Idno = "10", Orig = "3", Dest = "6", Cost = 2 });
//            Arc.arcs.Add(new Arc { Idno = "11", Orig = "4", Dest = "2", Cost = 15 });
//            Arc.arcs.Add(new Arc { Idno = "12", Orig = "4", Dest = "3", Cost = 11 });
//            Arc.arcs.Add(new Arc { Idno = "13", Orig = "4", Dest = "5", Cost = 6 });
//            Arc.arcs.Add(new Arc { Idno = "14", Orig = "5", Dest = "4", Cost = 6 });
//            Arc.arcs.Add(new Arc { Idno = "15", Orig = "5", Dest = "6", Cost = 9 });
//            Arc.arcs.Add(new Arc { Idno = "16", Orig = "6", Dest = "1", Cost = 14 });
//            Arc.arcs.Add(new Arc { Idno = "17", Orig = "6", Dest = "3", Cost = 2 });
//            Arc.arcs.Add(new Arc { Idno = "18", Orig = "6", Dest = "5", Cost = 9 });

//            Arc obj = new Arc();
//            obj.NodesBackarcAssingment();
//        }
//        [TestMethod]
//        public void UpdateNodesPropertiesTest()
//        {
//            NetworkAssignment();
//            SearchAlgorithm obj1 = new SearchAlgorithm();
//            obj1.UpdateNodesProperties();

//            Assert.AreEqual(20, Arc.NodeCost["1"]);
//            Assert.AreEqual(21, Arc.NodeCost["2"]);

//            Assert.AreEqual("3", Arc.NodeSuccessor["1"]);
//            Assert.AreEqual("4", Arc.NodeSuccessor["2"]);
//        }

//        [TestMethod]
//        public void ShortestPathTst()
//        {
//            ///<summary>
//            ///  Node Cost  Successor
//            ///  1      20      3
//            ///  2      21      4           Path From 1 -> 5 => 1->3
//            ///  3      11      6                               3->6    (1-3-6-5)
//            ///  4      6       5                               6->5
//            ///  5      0       null
//            ///  6      9       5
//            ///</summary>
//            NetworkAssignment();
//            SearchAlgorithm obj2 = new SearchAlgorithm();
//            obj2.ShortestPath();

//            List<string> path = new List<string>() { "1", "4", "3", "5" };
//            Assert.AreEqual(path[0], obj2.SHPath[0]);
//            Assert.AreEqual(path[1], obj2.SHPath[1]);
//            Assert.AreEqual(path[2], obj2.SHPath[2]);
//            Assert.AreEqual(path[3], obj2.SHPath[3]);
//        }
//    }
//}
