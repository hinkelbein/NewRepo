using BenchmarkDotNet.Attributes;

namespace BenchMarkExample
{
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    [MemoryDiagnoser]
    public class Comparison
    {
        Dictionary search = new Dictionary();
        [Benchmark]
        public void LowestNodeCostByLinq()
        {

            search.LowestNodeCostByLinq();
        }
        [Benchmark]
        public void LowestNodeCostBySorting()
        {
            search.LowestNodeCostBySorting();
        }
        [Benchmark]
        public void LowestNodeCostByManualSorting()
        {
            search.LowestNodeCostByManualSorting();
        }

    }
}
