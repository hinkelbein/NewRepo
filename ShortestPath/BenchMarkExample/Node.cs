namespace BenchMarkExample
{
    public class Node
    {
        string ID { get; set; }
        int Cost { get; set; }

        List<Node> nodes = new List<Node>();

        public Node()
        {

        }
    }
}
