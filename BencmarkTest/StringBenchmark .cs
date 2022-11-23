using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;


namespace BencmarkTest
{
    [MemoryDiagnoser]
    public class StringBenchmark
    {

        [Params(5, 5)]
        public int N;

        [Benchmark]
        public void RegularString()
        {
            string word = "";
            for (int i = 0; i < N; i++)
            {
                word += i;
            }
        }

        [Benchmark]
        public void StringBuilder()
        {
            StringBuilder word = new StringBuilder("");
            for (int i = 0; i < N; i++)
            {
                word.Append(i);
            }
        }
    }
}