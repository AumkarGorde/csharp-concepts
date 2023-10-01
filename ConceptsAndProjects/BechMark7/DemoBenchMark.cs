using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BechMark7
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class DemoBenchMark
    {
        private int[] numbers;
        [GlobalSetup]
        public void Setup()
        {
            numbers = new int[1000];
            // Initialize the array with data
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
        }
        [Benchmark]
        public int SumWithLINQ()
        {
            return numbers.Sum();
        }
        [Benchmark]
        public int SumWithForLoop()
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
