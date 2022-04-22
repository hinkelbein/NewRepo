using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;
using ShortestPath1;

namespace BenchMarkExample
{
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    [MemoryDiagnoser]
    public class Comparison
    {
        [Benchmark]
        public void Implementatio()
        {
            ShortestPath1.Arc.arcs = JsonConvert.DeserializeObject<List<Arc>>(File.ReadAllText("D:/ShortestPath/ShortestPathInput.txt"));
            Arc obj = new Arc();
            //obj.NodeAssignment();
            //obj.UpdateNodesProperties();

            //ShortestPathAlgorithm obj1 = new ShortestPathAlgorithm();
            //obj1.ShortestPath();
        }
    }
}
