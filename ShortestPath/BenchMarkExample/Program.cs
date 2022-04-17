using BenchmarkDotNet.Running;

namespace BenchMarkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Comparison>();
        }

    }
}
