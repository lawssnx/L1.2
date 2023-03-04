using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dictionary1 = new Dictionary<string, int>()
        {
            { "key1", 1 },
            { "key2", 2 },
            { "key3", 3 },
        };
        Dictionary<string, int> dictionary2 = new Dictionary<string, int>()
        {
            {"key1", 1 },
            {"key2", 2 },
        };
        var equalKeys = dictionary1.Keys.Intersect(dictionary2.Keys);
        var equalValues = from key in equalKeys
                          where dictionary1[key] == dictionary2[key]
                          select new {Key = key, Value = dictionary1[key]};
        foreach (var equals in equalValues)
        {
            Console.WriteLine("{0}: {1} is present in both x and y", equals.Key, equals.Value);
        }

    }
}
