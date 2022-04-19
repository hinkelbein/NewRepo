namespace ShortestPath
{
    public class Search
    {
        public static string Origin;
        public static string Destination;
        List<Node> ExtractedNodes = new List<Node>();
        public void UpdateNodesProperties()
        {
            var des = Node.NetworkNodes.Find(node => node.ID == Destination);
            des.Cost = 0;
            int n = 0;
            while (true)
            {
                List<Arc> backwardArcs = Arc.arcs.Where(arc => arc.Dest.Contains(des.ID)).ToList();  // Backward Arcs
                List<Node> precedNodes = Node.NetworkNodes.Where(node => backwardArcs.Any(arc => node.ID == arc.Orig)).ToList();  // Precede Nodes

                foreach (Node node in precedNodes)
                {
                    foreach (var arc in Arc.arcs)
                    {
                        if (arc.Orig.Contains(node.ID) && arc.Dest.Contains(des.ID)) // Bellman Theory application "Wi <= Carc + Wj"
                        {
                            if (!(node.Cost <= arc.Cost + des.Cost))
                            {
                                node.Cost = arc.Cost + des.Cost;
                                node.Successor = des.ID;
                            }
                        }
                    }
                }
                ExtractedNodes.Add(des);
                Node.NetworkNodes.Remove(des);

                n += 1;
                List<Node> newDes = Node.NetworkNodes.OrderBy(node => node.Cost).ToList();
                if (Node.NetworkNodes.Count > 0)
                {
                    des = newDes.Where(node => node.Cost >= des.Cost).First();
                }
                else { break; }
            }
        }
        public void ShortestPath()
        {
            UpdateNodesProperties();
            List<string> ShortestPath = new List<string>();
            ShortestPath.Add(Origin);
            string followingNode = Origin;

            while (true)
            {
                var FollowingNode = ExtractedNodes.Find(node => node.ID == Origin);
                Origin = FollowingNode.Successor;
                ShortestPath.Add(Origin);
                if (Origin == Destination) { break; }
            }

            Console.WriteLine($"Sequence of shortest path elements are as:");
            foreach (string node in ShortestPath)
            {
                Console.WriteLine(node);
            }
            Console.ReadKey();
        }
    }
}
