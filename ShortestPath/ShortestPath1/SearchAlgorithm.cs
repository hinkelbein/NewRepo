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
                var des1 = Arc.NodeCost.Where(node => node.Value >= Arc.NodeCost[Destination]).Min(new Comparer());
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
            HeapInitialization();
            UpdateNodesProperties();
            SHPath.Add(Origin);

            while (true)
            {
                string FollowingNode = Arc.NodeSuccessor[Origin];
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

        private void HeapInitialization()
        {
            Heap heap = new Heap(Arc.NodeCost);
        }
    }
}
