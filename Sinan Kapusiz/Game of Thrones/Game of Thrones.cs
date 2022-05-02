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
     * Complete the 'gameOfThrones' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string gameOfThrones(string s)
    {
        int[] a = new int[26];
        for (int i = 0; i < s.Length; i++) {
            int index = s[i] - 'a';
            a[index]++;
        }
        int oddCount = 0;
        for (int i = 0; i < 26; i++) {
            if (a[i] != 0) {
                if ((a[i] & 1) == 1) {
                    oddCount++;
                }
            }
        }
        return oddCount > 1 ? "NO" : "YES";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.gameOfThrones(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}