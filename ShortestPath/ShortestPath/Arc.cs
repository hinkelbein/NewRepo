namespace ShortestPath
{
    public class Arc
    {
        public string Idno { get; set; }
        public string Orig { get; set; }
        public string Dest { get; set; }
        public double Cost { get; set; }

        public static List<Arc> arcs = new List<Arc>( );
        public static Dictionary<string,List<Arc>> Network_Nods_BackArcs = new Dictionary<string,List<Arc>>( );


        public Arc(List<Arc> Arcs)
        {
            arcs = Arcs;
        }
        public void NodeAssignment()
        {
            foreach (Arc arc in arcs)
            {
                if (!Network_Nods_BackArcs.ContainsKey(arc.Dest))
                {
                    NodesInitialization(arc.Dest);
                    List<Arc> list = new List<Arc>( ) { arc };
                    Network_Nods_BackArcs.Add(arc.Dest,list);
                }
                else
                {
                    Network_Nods_BackArcs[arc.Dest].Add(arc);
                }
            }
        }

        public static Node NodesInitialization(string orig)  // Initialization Node's Costs and Successors
        {
            Node node = new Node(orig,double.PositiveInfinity,"1");
            Node.NetworkNodes.Add(node);
            return node;
        }
    }
}
