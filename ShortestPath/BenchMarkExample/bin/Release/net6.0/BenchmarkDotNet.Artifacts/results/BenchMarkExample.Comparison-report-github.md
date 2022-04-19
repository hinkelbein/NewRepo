``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.202
  [Host]     : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  DefaultJob : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT


```
|                        Method |      Mean |    Error |   StdDev | Rank |  Gen 0 | Allocated |
|------------------------------ |----------:|---------:|---------:|-----:|-------:|----------:|
| LowestNodeCostByManualSorting |  86.34 ns | 0.277 ns | 0.232 ns |    1 | 0.0134 |      56 B |
|          LowestNodeCostByLinq | 213.42 ns | 0.620 ns | 0.549 ns |    2 | 0.0362 |     152 B |
|       LowestNodeCostBySorting | 224.78 ns | 0.682 ns | 0.605 ns |    3 | 0.0572 |     240 B |
