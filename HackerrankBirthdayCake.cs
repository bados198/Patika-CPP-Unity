using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        Console.ReadLine();
        var heights = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var max = heights.Max();
        var count = heights.Count(it => it == max);
        Console.WriteLine(count);
    }
}
