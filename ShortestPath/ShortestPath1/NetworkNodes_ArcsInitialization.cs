namespace ShortestPath1
{
    public class NetworkNodes_ArcsInitialization
    {
        public string Idno { get; set; }
        public string Orig { get; set; }
        public string Dest { get; set; }
        public double Cost { get; set; }

        public static List<NetworkNodes_ArcsInitialization> arcs = new List<NetworkNodes_ArcsInitialization>();
        public static Dictionary<string, List<NetworkNodes_ArcsInitialization>> BackArcs = new Dictionary<string, List<NetworkNodes_ArcsInitialization>>();
        public static Dictionary<string, double> NodeCost = new Dictionary<string, double>();
        public static Dictionary<string, string> NodeSuccessor = new Dictionary<string, string>();

        public void NodesBackarcAssingment()
        {
            foreach (NetworkNodes_ArcsInitialization arc in arcs)
            {
                if (!NodeCost.ContainsKey(arc.Orig)) { NodesInitialization(arc.Orig); }
                if (!NodeCost.ContainsKey(arc.Dest)) { NodesInitialization(arc.Dest); }

                if (!BackArcs.ContainsKey(arc.Dest))
                {
                    List<NetworkNodes_ArcsInitialization> list = new List<NetworkNodes_ArcsInitialization>() { arc };
                    BackArcs.Add(arc.Dest, list);
                }
                else
                {
                    BackArcs[arc.Dest].Add(arc);
                }
            }
        }
        public void NodesInitialization(string dest)
        {
            NodeCost.Add(dest, double.PositiveInfinity);
            NodeSuccessor.Add(dest, " ");
        }
    }
}
