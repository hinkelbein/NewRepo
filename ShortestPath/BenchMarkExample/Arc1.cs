namespace BenchMarkExample
{
    public class Arc1
    {
        public string Idno { get; set; }
        public string Orig { get; set; }
        public string Dest { get; set; }
        public double Cost { get; set; }

        public static List<Arc1> arcs = new List<Arc1>();
        public static Dictionary<string, List<Arc1>> BackArcs = new Dictionary<string, List<Arc1>>();
        public static Dictionary<string, double> NodeCost = new Dictionary<string, double>();
        public static Dictionary<string, string> NodeSuccessor = new Dictionary<string, string>();

        public void NodeAssignment()
        {
            foreach (Arc1 arc in arcs)
            {
                if (!BackArcs.ContainsKey(arc.Dest))
                {
                    NodesInitialization(arc.Dest);
                    List<Arc1> list = new List<Arc1>() { arc };
                    BackArcs.Add(arc.Dest, list);
                }
                else
                {
                    BackArcs[arc.Dest].Add(arc);
                }
            }
        }

        private void NodesInitialization(string dest)
        {
            NodeCost.Add(dest, double.PositiveInfinity);
            NodeSuccessor.Add(dest, " ");
        }
    }
}
