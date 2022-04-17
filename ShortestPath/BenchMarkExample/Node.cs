namespace BenchMarkExample
{
    public class Node
    {
        public string ID { get; set; }
        public double Cost { get; set; }             // Node Cost.
        public string Successor { get; set; }        // Node Successor.
        public static List<Node> NetworkNodes = new List<Node>();     // Aggregation of all the network nodes as list of nodes.

        public Node(string ID, double Cost, string Successor)
        {
            this.ID = ID;
            this.Cost = Cost;
            this.Successor = Successor;
        }
    }
}
