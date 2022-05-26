using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        var n = int.Parse(ReadLine());
        for (int i = 1; i <= n; i++)
        {
            var spaces = new String(' ', n - i);
            var hashes = new String('#', i);
            WriteLine(spaces + hashes);
        }
    }
}
