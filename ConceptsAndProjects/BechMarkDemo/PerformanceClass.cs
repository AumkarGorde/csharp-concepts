using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BechMarkDemo
{
    public class PerformanceClass
    {
        private int[] numbers;

        public int SumWithForLoop()
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        
        public int SumWithLINQ()
        {
            return numbers.Sum();
        }
    }
}
