using System.Collections.Generic;
using System;
class Solution
{
    static void Main(string[] args)
    {
        var rockCount = int.Parse(Console.ReadLine());
        var mineralMap = new Dictionary<char, int>();
        var rock = Console.ReadLine();
        foreach (var mineral in rock)
        {
            if (!mineralMap.ContainsKey(mineral))
                mineralMap.Add(mineral, 1);
        }

        for (var i = 1; i < rockCount; i++)
        {
            rock = Console.ReadLine();

            var currentRockUniqueMinerals = new HashSet<char>();
            foreach (var mineral in rock)
            {
                if (mineralMap.ContainsKey(mineral) && !currentRockUniqueMinerals.Contains(mineral))
                {

                    mineralMap[mineral]++;
                    currentRockUniqueMinerals.Add(mineral);
                }
            }
        }

        var gemstonesCount = 0;
        foreach (var mineral in mineralMap)
        {
            if (mineral.Value == rockCount)
                gemstonesCount++;
        }
        Console.WriteLine(gemstonesCount);
    }
}
