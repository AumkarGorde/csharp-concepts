```

BenchmarkDotNet v0.13.8, Windows 11 (10.0.22621.2283/22H2/2022Update/SunValley2)
Intel Core i5-9300H CPU 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.400
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
| Method         | Mean     | Error   | StdDev   | Median   | Rank | Allocated |
|--------------- |---------:|--------:|---------:|---------:|-----:|----------:|
| SumWithLINQ    | 375.9 ns | 7.17 ns |  6.71 ns | 374.3 ns |    1 |         - |
| SumWithForLoop | 447.2 ns | 8.91 ns | 22.52 ns | 438.9 ns |    2 |         - |
