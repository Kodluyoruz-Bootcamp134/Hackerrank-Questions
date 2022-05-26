using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var line = Console.ReadLine();

        if (n == 1) { Console.WriteLine(0); return; }
        int ans = 0;
        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                if (i == j) continue;
                ans = Math.Max(ans, alternating(line, (char)('a' + i), (char)('a' + j)));
            }
        }
        Console.WriteLine(ans);
    }
    static int alternating(string line, char p1, char p2)
    {
        bool first = true;
        int r = 0;
        foreach (var c in line.Where(x => x == p1 || x == p2))
        {
            if (first)
            {
                if (c == p2) return -1;
                r++;
            }
            else
            {
                if (c == p1) return -1;
                r++;
            }
            first = !first;
        }
        return r;
    }
}
