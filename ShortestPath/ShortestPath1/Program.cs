﻿using Newtonsoft.Json;

namespace ShortestPath1
{
    class program
    {
        static void Main(string[] args)
        {
            InputData();
            Implementation();
        }

        static void Implementation()
        {
            NetworkNodes_ArcsInitialization.arcs = JsonConvert.DeserializeObject<List<NetworkNodes_ArcsInitialization>>(File.ReadAllText("C:/Users/javad/source/repos/NewRepo/ShortestPath/ShortestPathInput.txt"));

            NetworkNodes_ArcsInitialization obj = new NetworkNodes_ArcsInitialization();
            obj.NodesBackarcAssingment();

            SearchAlgorithm obj1 = new SearchAlgorithm();
            obj1.ShortestPath();
        }

        static void InputData()
        {
            Console.WriteLine("Please choose your Origin-Destination couple\nYou are allowed to choose numbers between 1-6");
            SearchAlgorithm.Origin = InputAccuracy();
            SearchAlgorithm.Destination = InputAccuracy();
            SearchAlgorithm.MainDestination = SearchAlgorithm.Destination;
        }

        static string InputAccuracy()
        {
            while (true)
            {
                int input = Int16.Parse(Console.ReadLine());
                if (SearchAlgorithm.Origin == null && input >= 1 && input <= 6)
                {
                    return input.ToString();
                }
                else if (SearchAlgorithm.Origin != null && input >= 1 && input <= 6)
                {
                    if (input.ToString() == SearchAlgorithm.Origin)
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

