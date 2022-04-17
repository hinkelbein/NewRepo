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
            Arc1.NodeCost[Destination] = 0;

            for (int i = 0; i < Arc1.NodeCost.Count; i++)
            {
                List<Arc1> backwardArcs = Arc1.BackArcs[Destination];

                foreach (Arc1 arc in backwardArcs)
                {
                    if (!(Arc1.NodeCost[arc.Orig] <= arc.Cost + Arc1.NodeCost[Destination]))
                    {
                        Arc1.NodeCost[arc.Orig] = arc.Cost + Arc1.NodeCost[Destination];
                        Arc1.NodeSuccessor[arc.Orig] = arc.Dest;
                    }
                }
                ExtractedNodes.Add(Destination);
                //Arc.NodeCost.Remove(Destination);
                //Destination = Arc.NodeCost.MinBy(x => x.Value).Key;
                var des = Arc1.NodeCost.OrderBy(x => x.Value).Where(node => node.Value >= Arc1.NodeCost[Destination]);
                foreach (KeyValuePair<string, double> item in des)
                {
                    if (item.Key != Destination)
                    {
                        Destination = item.Key;
                        break;
                    }
                }

                //if (Destination == Origin) { break; }
            }
        }
        public void ShortestPath()
        {
            UpdateNodesProperties();
            List<string> ShortestPath = new List<string>();
            ShortestPath.Add(Origin);

            while (true)
            {
                string FollowingNode = Arc1.NodeSuccessor[Origin];
                ShortestPath.Add(FollowingNode);
                Origin = FollowingNode;
                if (Origin == MainDestination) { break; }
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
