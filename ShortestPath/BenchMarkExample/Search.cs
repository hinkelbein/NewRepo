namespace BenchMarkExample
{
    public class Search
    {
        Dictionary<string, int> DicNumber = new Dictionary<string, int>()
        {
            {"a",10},
            {"b",5},
            {"d",8},
            {"h",97},
            {"s",6584},
            {"m", 2},
            {"q",99},
            {"jh",76}
        };

        public void LowestNodeCostByLinq()
        {
            var L = DicNumber.OrderBy(x => x.Value).First();
        }

        public void LowestNodeCostByLoop()
        {
            foreach (var item in DicNumber)
            {

            }
        }
    }
}
