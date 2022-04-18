using Newtonsoft.Json;
using System.Diagnostics;

namespace ShortestPath1
{
    class program
    {
        public static Stopwatch watch = new Stopwatch();
        public static double elapsedTime;
        static void Main(string[] args)
        {
            watch.Reset();
            watch.Start();
            //InputData();
            Implementation();
        }

        static void Implementation()
        {
            Arc.arcs = JsonConvert.DeserializeObject<List<Arc>>(File.ReadAllText("D:/ShortestPath/ShortestPathInput.txt"));

            Arc obj = new Arc();
            obj.NodeAssignment();

            ShortestPathAlgorithm obj1 = new ShortestPathAlgorithm();
            obj1.ShortestPath();

            watch.Stop();
            elapsedTime = watch.ElapsedMilliseconds / 1000.0;
            Console.WriteLine(elapsedTime);
        }

        static void InputData()
        {
            Console.WriteLine("Please choose your Origin-Destination couple\nYou are allowed to choose numbers between 1-6");
            ShortestPathAlgorithm.Origin = InputAccuracy();
            ShortestPathAlgorithm.Destination = InputAccuracy();
            ShortestPathAlgorithm.MainDestination = ShortestPathAlgorithm.Destination;


        }

        static string InputAccuracy()
        {
            while (true)
            {
                int input = Int16.Parse(Console.ReadLine());
                if (ShortestPathAlgorithm.Origin == null && input >= 1 && input <= 6)
                {
                    return input.ToString();
                }
                else if (ShortestPathAlgorithm.Origin != null && input >= 1 && input <= 6)
                {
                    if (input.ToString() == ShortestPathAlgorithm.Origin)
                    {
                        Console.WriteLine("Entered number is repeated, please try another number for destination");
                    }
                    else
                    {
                        return input.ToString();
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input data, Please enter a number between 1-6");
                }
            }
        }
    }
}

