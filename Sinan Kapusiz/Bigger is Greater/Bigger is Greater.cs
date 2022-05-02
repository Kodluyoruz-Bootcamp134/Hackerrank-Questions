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
     * Complete the 'biggerIsGreater' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING w as parameter.
     */

    public static string biggerIsGreater(string w)
    {
        char[] chars = w.ToCharArray();
        int i = chars.Length-1;
        while(i > 0)
        {
            if(chars[i-1] >= chars[i])
            {
                i--;
            }
            else
            {
                int j=i;
                while(j < chars.Length && chars[j] > chars[i-1]){
                    j++;
                }
                char temp = chars[i-1];
                chars[i-1]=chars[j-1];
                chars[j-1]=temp;
                
                char[] newChar = new char[chars.Length];
                for(int k=0;k<i;k++){
                    newChar[k]=chars[k];
                }
                int end = chars.Length-1;
                for(int k=i;k<chars.Length;k++){
                    newChar[k]=chars[end--];
                }
                return new string(newChar);
            }
        }
        return "no answer";
         
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            string w = Console.ReadLine();

            string result = Result.biggerIsGreater(w);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}