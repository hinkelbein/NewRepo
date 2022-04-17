using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;

namespace BenchMarkExample
{

    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Comparison
    {

        [Benchmark]
        public void AssignmentByClass()
        {
            Arc.arcs = JsonConvert.DeserializeObject<List<Arc>>(File.ReadAllText("D:/ShortestPath/ShortestPathInput.txt"));
            Arc obj = new Arc();
            obj.NodeAssignment();
        }

        [Benchmark]
        public void Algorithm()
        {
            Search obj2 = new Search();
            Search.Origin = "1";
            Search.Destination = "5";

            obj2.ShortestPath();
        }

        //[Benchmark]
        //public void AssignmentByCollection()
        //{
        //    Arc1.arcs = JsonConvert.DeserializeObject<List<Arc1>>(File.ReadAllText("D:/ShortestPath/ShortestPathInput.txt"));
        //    Arc1 obj1 = new Arc1();
        //    obj1.NodeAssignment();

        //    ShortestPathAlgorithm obj3 = new ShortestPathAlgorithm();
        //    obj3.ShortestPath();
        //}

    }
}
