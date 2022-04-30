using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result//Sinan Kapusiz.
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double posN = 0,negN = 0,zeroN = 0;
        foreach(var ar in arr)
        {
            if(ar>0)
                posN++;
            else if(ar<0)
                negN++;
            else
                zeroN++;
        }
            Console.WriteLine(posN/arr.Count);
            Console.WriteLine(negN/arr.Count);
            Console.WriteLine(zeroN/arr.Count);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
