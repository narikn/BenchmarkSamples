using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System;

public class StringsTest
{
    private readonly Dictionary<string, string> _stringsToTest =
         new Dictionary<string, string>
         {
             { "Test", "test" },
             { "7", "7" },
             { "A long string", "Does not match" },
             { "Testing", "Testing" },
             { "8", "2" }
         };


    [Benchmark]
    public bool EqualsOperator()
    {
        var result = false;

        foreach (var item in _stringsToTest)
        {
            result = item.Key.ToLower() == item.Value.ToLower();
        }

        return result;
    }

    [Benchmark]
    public bool EqualsFunction()
    {
        var result = false;

        foreach (var item in _stringsToTest)
        {
            result = string.Equals(item.Key, item.Value,
                                   StringComparison.OrdinalIgnoreCase);
        }

        return result;
    }
}