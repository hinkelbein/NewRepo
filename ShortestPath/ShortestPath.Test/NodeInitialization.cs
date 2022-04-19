using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShortestPath.Test
{
    [TestClass]
    public class NodesTest
    {
        [TestMethod]
        public void Constructor()
        {
            var nodes = new Node("5", 200, "6");
            Assert.IsNotNull(nodes);
            Assert.AreEqual("5", nodes.ID);
        }

        //[TestMethod]
        //public void nodesInitialization()
        //{

        //    Nodes.nodes = new List<string>();
        //    Nodes.nodes.Add("1");
        //    Nodes.nodes.Add("10");
        //    Nodes.nodes.Add("11");
        //    Nodes.nodes.Add("12");
        //    Nodes.nodesInitialization( );
        //    Assert.AreEqual("1",Nodes.networkNodes[0].id);
        //    Assert.AreEqual(double.PositiveInfinity,Nodes.networkNodes[0].NCost);
        //    //Assert.AreEqual(double.PositiveInfinity,Nodes.networkNodes[0].NCost);
        //}
    }
}