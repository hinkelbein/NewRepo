namespace BenchMarkExample
{
    public class Dictionary
    {
        public Dictionary<string, int> DicNumber = new Dictionary<string, int>()
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
        public Dictionary<string, int> DicNumber1 = new Dictionary<string, int>();

        public void NodeAssignment()
        {
            foreach (KeyValuePair<string, int> item in DicNumber)
            {
                DicNumber1.Add(item.Key, item.Value);
            }
        }
        public void LowestNodeCostByLinq()
        {
            var L = DicNumber.OrderBy(x => x.Value).First();
        }

        public void LowestNodeCostByManualSorting()
        {
            var node = DicNumber.First();
            foreach (KeyValuePair<string, int> item in DicNumber)
            {
                if (item.Value < node.Value)
                { node = item; }
            }
        }

        public void LowestNodeCostBySorting()
        {
            //var myList = DicNumber.ToList();
            DicNumber.ToList().Sort((x, y) => x.Value.CompareTo(y.Value));
            var lc = DicNumber.First();
        }
    }
}
