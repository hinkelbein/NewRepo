namespace ShortestPath1
{
    public class Node
    {
        public Node Parent;
        public Node Left;
        public Node Right;

        public string ID { get; set; }
        public double Cost { get; set; }
        public Node(double cost, Node p)
        {
            Cost = cost;
            Parent = p;
        }
        public Node(string id, double cost)
        {
            ID = id;
            Cost = cost;
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
