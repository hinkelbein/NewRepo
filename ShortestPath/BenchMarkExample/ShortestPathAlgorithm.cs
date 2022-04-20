namespace BenchMarkExample
{
    public class ShortestPathAlgorithm
    {
        public static string Origin = "1";
        public static string Destination = "5";
        public static string MainDestination = "5";

        List<string> ExtractedNodes = new List<string>();
        public void UpdateNodesProperties()
        {
            Arc.NodeCost[Destination] = 0;

            for (int i = 0; i < Arc.NodeCost.Count; i++)
            {
                List<Arc> backwardArcs = Arc.BackArcs[Destination];

                foreach (Arc arc in backwardArcs)
                {
                    if (!(Arc.NodeCost[arc.Orig] <= arc.Cost + Arc.NodeCost[Destination]))
                    {
                        Arc.NodeCost[arc.Orig] = arc.Cost + Arc.NodeCost[Destination];
                        Arc.NodeSuccessor[arc.Orig] = arc.Dest;
                    }
                }

                ExtractedNodes.Add(Destination);
                var des = Arc.NodeCost.OrderBy(x => x.Value).Where(node => node.Value >= Arc.NodeCost[Destination]);
                foreach (KeyValuePair<string, double> item in des)
                {
                    if (item.Key != Destination)
                    {
                        Destination = item.Key;
                        break;
                    }
                }
            }
        }
        public void ShortestPath()
        {
            UpdateNodesProperties();
            List<string> ShortestPath = new List<string>();
            ShortestPath.Add(Origin);

            while (true)
            {
                string FollowingNode = Arc.NodeSuccessor[Origin];
                ShortestPath.Add(FollowingNode);
                Origin = FollowingNode;
                if (Origin == MainDestination) { break; }
            }

            Console.WriteLine($"Sequence of shortest path elements are as:");
            foreach (string node in ShortestPath)
            {
                Console.WriteLine(node);
            }
        }
    }
}
