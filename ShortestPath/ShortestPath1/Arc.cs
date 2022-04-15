namespace ShortestPath1
{
    public class Arc
    {
        public string Idno { get; set; }
        public string Orig { get; set; }
        public string Dest { get; set; }
        public double Cost { get; set; }

        public static List<Arc> arcs = new List<Arc>( );
        public static Dictionary<string,List<Arc>> BackArcs = new Dictionary<string,List<Arc>>( );
        public static Dictionary<string,double> NodeCost = new Dictionary<string,double>( );
        public static Dictionary<string,string> NodeSuccessor = new Dictionary<string,string>( );


        public Arc(List<Arc> Arcs)
        {
            arcs = Arcs;
        }
        public void NodeAssignment()
        {
            foreach (Arc arc in arcs)
            {
                if (!BackArcs.ContainsKey(arc.Dest))
                {
                    NodesInitialization(arc.Dest);
                    List<Arc> list = new List<Arc>( ) { arc };
                    BackArcs.Add(arc.Dest,list);
                }
                else
                {
                    BackArcs[arc.Dest].Add(arc);
                }
            }
        }

        private void NodesInitialization(string dest)
        {
            NodeCost.Add(dest,double.PositiveInfinity);
            NodeSuccessor.Add(dest," ");
        }
    }
}
