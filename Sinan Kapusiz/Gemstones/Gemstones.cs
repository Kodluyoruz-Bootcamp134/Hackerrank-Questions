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

class Result //Sinan Kapusiz.
{

    /*
     * Complete the 'gemstones' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING_ARRAY arr as parameter.
     */

    public static int gemstones(List<string> arr)
    {
        int counter = 0;
        String mainSeed = arr[0];
        List<String> gems = new List<string>();
        int _sampleLength = 1;
        while (_sampleLength <= mainSeed.Length)
        {
            int _sampleOffset = 0;
            while (_sampleOffset <= mainSeed.Length - _sampleLength)
            {
                String _sample = mainSeed.Substring(_sampleOffset, _sampleLength);
                if (!gems.Contains(_sample))
                    gems.Add(_sample);
                _sampleOffset++;
            }
            _sampleLength++;
        }
        foreach (string gem in gems)
        {
            if (hasGem(gem, arr))
                counter++;
        }
        return counter;
    }
    
    public static bool hasGem(string gem, List<string> arr)
    {
        for (int index = 1; index < arr.Count; index++)
        {
            if (arr[index].IndexOf(gem) == -1)
                return false;
        }
        return true;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> arr = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string arrItem = Console.ReadLine();
            arr.Add(arrItem);
        }

        int result = Result.gemstones(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
