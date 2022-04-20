namespace ShortestPath1
{
    public class SearchAlgorithm
    {
        public static string Origin;
        public static string Destination;
        public static string MainDestination;
        public List<string> SHPath = new List<string>();

        List<string> ExtractedNodes = new List<string>();
        public void UpdateNodesProperties()
        {
            NetworkNodes_ArcsInitialization.NodeCost[Destination] = 0;

            for (int i = 0; i < NetworkNodes_ArcsInitialization.NodeCost.Count; i++)
            {
                List<NetworkNodes_ArcsInitialization> backwardArcs = NetworkNodes_ArcsInitialization.BackArcs[Destination];

                foreach (NetworkNodes_ArcsInitialization arc in backwardArcs)
                {
                    if (!(NetworkNodes_ArcsInitialization.NodeCost[arc.Orig] <= arc.Cost + NetworkNodes_ArcsInitialization.NodeCost[Destination]))
                    {
                        NetworkNodes_ArcsInitialization.NodeCost[arc.Orig] = arc.Cost + NetworkNodes_ArcsInitialization.NodeCost[Destination];
                        NetworkNodes_ArcsInitialization.NodeSuccessor[arc.Orig] = arc.Dest;
                    }
                }

                ExtractedNodes.Add(Destination);
                var des = NetworkNodes_ArcsInitialization.NodeCost.OrderBy(x => x.Value).Where(node => node.Value >= NetworkNodes_ArcsInitialization.NodeCost[Destination]);
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
            SHPath.Add(Origin);

            while (true)
            {
                string FollowingNode = NetworkNodes_ArcsInitialization.NodeSuccessor[Origin];
                SHPath.Add(FollowingNode);
                Origin = FollowingNode;
                if (Origin == MainDestination) { break; }
            }

            Console.WriteLine($"Sequence of shortest path elements are as:");
            foreach (string node in SHPath)
            {
                Console.WriteLine(node);
            }
        }
    }
}
