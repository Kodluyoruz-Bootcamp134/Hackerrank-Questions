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
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
            int []A = new int[26];
            for (int i = 0; i < 26; ++i)
                A[i] = 0;
            s = s.ToLower();
            for(int i = 0; i < s.Length; ++i)
            {
                if(s[i] != ' ')
                {
                    A[s[i] - 'a'] = 1;
                }
            }
            int j = 0;
            for (j = 0; j < 26; ++j)
                if (A[j] == 0)
                    break;
            if (j == 26)
                return "pangram";
            else
                return "not pangram";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
