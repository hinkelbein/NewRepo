namespace BenchMarkExample
{
    public class Node
    {
        string ID { get; set; }
        int Cost { get; set; }

        public static List<Node> nodes = new List<Node>();
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

        public Node(string ID, int Cost)
        {
            this.ID = ID;
            this.Cost = Cost;
        }
        public Node() { }

        public void NodeAssignment()
        {
            foreach (KeyValuePair<string, int> item in DicNumber)
            {
                Node node = new Node(item.Key, item.Value);
                nodes.Add(node);
            }
        }

        public void NodesOrderingByClass()
        {
            NodeAssignment();
            var node = nodes.OrderBy(x => x.Cost).First();
        }

    }
}
