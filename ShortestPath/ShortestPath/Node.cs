namespace ShortestPath
{
    public class Node
    {
        public Node Parent;
        public Node Left;
        public Node Right;

        public string ID { get; set; }
        public double Cost { get; set; }             // Node Cost.
        public string Successor { get; set; }        // Node Successor.
        public static Dictionary<string, Node> NetworkNodes = new Dictionary<string, Node>();     // Aggregation of all the network nodes as list of nodes.

        public Node(string ID, double Cost, string Successor)
        {
            this.ID = ID;
            this.Cost = Cost;
            this.Successor = Successor;
        }
        public Node(double cost, Node p)
        {
            Cost = cost;
            Parent = p;
        }

        public Node(Node p)
        {
            Parent = p;
        }

        public Node(double cost)
        {
            Cost = cost;
        }

        public Node()
        {

        }
    }
}
