namespace ShortestPath1
{
    public class Arc
    {
        public string Idno { get; set; }
        public string Orig { get; set; }
        public string Dest { get; set; }
        public double Cost { get; set; }

        public static List<Arc> arcs = new List<Arc>();
        public static Dictionary<string, List<Arc>> BackArcs = new Dictionary<string, List<Arc>>();
        public static Dictionary<string, double> NodeCost = new Dictionary<string, double>();
        public static Dictionary<string, string> NodeSuccessor = new Dictionary<string, string>();

        public void NodesBackarcAssingment()
        {
            for (int i = 0; i < arcs.Count; i++)
            {
                if (i == 0)
                {
                    NodesInitialization(arcs[i].Orig);
                }

                if (!BackArcs.ContainsKey(arcs[i].Dest))
                {
                    NodesInitialization(arcs[i].Dest);
                    List<Arc> list = new List<Arc>() { arcs[i] };
                    BackArcs.Add(arcs[i].Dest, list);
                }
                else
                {
                    BackArcs[arcs[i].Dest].Add(arcs[i]);
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
