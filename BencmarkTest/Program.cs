﻿using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BencmarkTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var stringBenchmark = BenchmarkRunner.Run<StringBenchmark>();
            BenchmarkRunner.Run<StringBenchmark>();
        }
    }
}
