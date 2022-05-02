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

class Result//Sinan KAPUSIZ.
{

    /*
     * Complete the 'commonChild' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING s1
     *  2. STRING s2
     */

    public static int commonChild(string s1, string s2)
    {
        int m = s1.Length;
        int n = s2.Length;
        int[,] s = new int[5001,5001];
        for(int i = 0; i <= m ; i++)
        {
            for(int j = 0; j <= n ; j++)
            {
                if(i == 0 || j == 0)
                {
                    s[i,j] = 0;
                }
                else if(s1[i-1] == s2[j-1])
                {
                    s[i,j] = s[i -1, j -1] + 1;
                }
                else
                {
                    s[i,j] = Math.Max(s[i,j-1], s[i-1,j]);
                }
            }
        }
        return s[m,n];
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s1 = Console.ReadLine();

        string s2 = Console.ReadLine();

        int result = Result.commonChild(s1, s2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}