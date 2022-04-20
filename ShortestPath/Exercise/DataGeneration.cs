namespace RandomDataGeneration
{
    public class DataGeneration
    {
        Dictionary<string, int> Data = new Dictionary<string, int>();
        public void Data_Assigning()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Random rnd = new Random(1000000000);
                rnd.Next();
                Data.Add(i.ToString(), rnd.Next());
            }
        }
    }
}
