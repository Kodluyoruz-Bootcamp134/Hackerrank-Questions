using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int runningTime(int[] A)
    {
        var shiftCount = 0;
        var j = 0;
        for (var i = 1; i < A.Length; i++)
        {
            var value = A[i];
            j = i - 1;
            while (j >= 0 && value < A[j])
            {
                A[j + 1] = A[j];
                shiftCount++;
                j = j - 1;
            }
            A[j + 1] = value;
        }
        return shiftCount;
    }

    static void Main(String[] args)
    {
       
        Console.ReadLine();
        var arr_temp = Console.ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, int.Parse);
        var result = runningTime(arr);
        Console.WriteLine(result);
    }
}
