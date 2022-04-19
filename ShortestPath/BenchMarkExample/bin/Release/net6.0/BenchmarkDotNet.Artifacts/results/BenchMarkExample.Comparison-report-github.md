``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.202
  [Host]     : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  DefaultJob : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT


```
|        Method |     Mean |    Error |   StdDev | Rank |  Gen 0 |  Gen 1 | Allocated |
|-------------- |---------:|---------:|---------:|-----:|-------:|-------:|----------:|
| Implementatio | 69.96 μs | 0.905 μs | 0.847 μs |    1 | 3.9063 | 0.9766 |     20 KB |
