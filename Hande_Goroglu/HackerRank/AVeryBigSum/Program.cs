using System;
class Solution
{
    static void Main(String[] args)
    {
        var finalSum = 0L;
        var n = int.Parse(Console.ReadLine());
        var ar_temp = Console.ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, long.Parse);

        for (int i = 0; i < n; i++)
            finalSum += ar[i];

        Console.WriteLine(finalSum);
    }
}
