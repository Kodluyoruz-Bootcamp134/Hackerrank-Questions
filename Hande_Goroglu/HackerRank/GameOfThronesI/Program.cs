using System.Collections.Generic;
using System;
class Solution
{
    static void Main(string[] args)
    {
        var inputLength = 0;
        var charMap = new Dictionary<int, int>();
        var nextChar = Console.Read();

        while (nextChar != -1)
        {
            inputLength++;
            if (charMap.ContainsKey(nextChar))
            {
                var currentCount = charMap[nextChar];
                if (currentCount == 1)
                    charMap[nextChar] = 0;
                else
                    charMap[nextChar] = 1;
            }
            else
                charMap.Add(nextChar, 1);

            nextChar = Console.Read();
        }

        var total = 0;
        foreach (var item in charMap)
            total += item.Value;

        if (inputLength % 2 == 0 && total == 0)
            Console.WriteLine("YES");
        else if (inputLength % 2 != 0 && total == 1)
            Console.WriteLine("YES");
        else
            Console.WriteLine("NO");
    }
}
