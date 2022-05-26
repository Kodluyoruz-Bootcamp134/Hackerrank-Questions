
using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        var positiveNumbers = 0;
        var negativeNumbers = 0;
        var zeroNumbers = 0;

        ReadLine();
        var arr_temp = ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, Int32.Parse);

        for (int arr_i = 0; arr_i < arr.Length; arr_i++)
        {
            if (arr[arr_i] > 0)
                ++positiveNumbers;
            else if (arr[arr_i] < 0)
                ++negativeNumbers;
            else
                ++zeroNumbers;
        }

        WriteLine((double)positiveNumbers / arr.Length);
        WriteLine((double)negativeNumbers / arr.Length);
        WriteLine((double)zeroNumbers / arr.Length);
    }
}
