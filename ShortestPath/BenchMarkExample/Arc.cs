//namespace BenchMarkExample
//{
//    public class Arc
//    {
//        public string Idno { get; set; }
//        public string Orig { get; set; }
//        public string Dest { get; set; }
//        public double Cost { get; set; }

//        public static List<Arc> arcs = new List<Arc>();
//        public static Dictionary<string, List<Arc>> BackArcs = new Dictionary<string, List<Arc>>();
//        public static Dictionary<string, double> NodeCost = new Dictionary<string, double>();
//        public static Dictionary<string, string> NodeSuccessor = new Dictionary<string, string>();

//        public void NodeAssignment()
//        {
//            foreach (Arc arc in arcs)
//            {
//                if (!BackArcs.ContainsKey(arc.Dest))
//                {
//                    NodesInitialization(arc.Dest);
//                    List<Arc> list = new List<Arc>() { arc };
//                    BackArcs.Add(arc.Dest, list);
//                }
//                else
//                {
//                    BackArcs[arc.Dest].Add(arc);
//                }
//            }
//        }

//        private void NodesInitialization(string dest)
//        {
//            NodeCost.Add(dest, double.PositiveInfinity);
//            NodeSuccessor.Add(dest, " ");
//        }
//        public static string Origin = "1";
//        public static string Destination = "5";
//        public static string MainDestination = "5";

//        List<string> ExtractedNodes = new List<string>();
//        public void UpdateNodesProperties()
//        {
//            Arc.NodeCost[Destination] = 0;

//            for (int i = 0; i < NodeCost.Count; i++)
//            {
//                List<Arc> backwardArcs = BackArcs[Destination];

//                foreach (Arc arc in backwardArcs)
//                {
//                    if (!(NodeCost[arc.Orig] <= arc.Cost + NodeCost[Destination]))
//                    {
//                        NodeCost[arc.Orig] = arc.Cost + NodeCost[Destination];
//                        NodeSuccessor[arc.Orig] = arc.Dest;
//                    }
//                }

//                ExtractedNodes.Add(Destination);
//                var des = NodeCost.OrderBy(x => x.Value).Where(node => node.Value >= NodeCost[Destination]);
//                foreach (KeyValuePair<string, double> item in des)
//                {
//                    if (item.Key != Destination)
//                    {
//                        Destination = item.Key;
//                        break;
//                    }
//                }
//            }
//        }
//        public void ShortestPath()
//        {
//            UpdateNodesProperties();
//            List<string> ShortestPath = new List<string>();
//            ShortestPath.Add(Origin);

//            while (true)
//            {
//                string FollowingNode = NodeSuccessor[Origin];
//                ShortestPath.Add(FollowingNode);
//                Origin = FollowingNode;
//                if (Origin == MainDestination) { break; }
//            }

//            Console.WriteLine($"Sequence of shortest path elements are as:");
//            foreach (string node in ShortestPath)
//            {
//                Console.WriteLine(node);
//            }
//            // Console.ReadKey();
//        }
//    }
//}
