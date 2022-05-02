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

class Result //Sinan KAPUSIZ
{

    /*
     * Complete the 'alternate' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int alternate(string s)
    {
        string kelime = s; 
        string d_kelime = KarakterBul(kelime);
        string s_kelime = string.Empty;
        return KarakterSilme(d_kelime, kelime, s_kelime);
    }
    
    public static int KarakterSilme(string d_kelime,string kelime,string s_kelime)
    {
        string s_kelimeSon = string.Empty;   
        for(int i = 0; i < d_kelime.Length ; i++)
        {
            for(int j = 0; j < d_kelime.Length ; j++)
            {
                if(j != i)
                {
                   for(int k = 0; k < kelime.Length ; k++)
                    {
                        if(kelime[k] == d_kelime[i] || kelime[k] == d_kelime[j])
                        {
                            s_kelime += kelime[k];
                        }
                        
                    } 
                }
                if(AyniKarakterBulma(s_kelime) == false)  
                {
                    if(s_kelime.Length > s_kelimeSon.Length)
                    {
                        s_kelimeSon = s_kelime;
                    }
                    
                }  
                 s_kelime = string.Empty;
            }
           
        }
        
        return s_kelimeSon.Length;
    }
    
    public static bool AyniKarakterBulma(string s_kelime)
    {
        for(int i = 0; i < (s_kelime.Length - 1)  ; i++)
        {
            if(s_kelime[i] == s_kelime[i+1])
            {
                return true;
            }
        }
        return false;
    }
    
    public static string KarakterBul(string kelime)//Dizi icerisindeki karakterleri buluyoruz.
    {
        string d_kelime = "";
        for(int i = 0; i < kelime.Length;i++)
        {
            if(d_kelime.IndexOf(kelime[i]) == -1)
            {
                d_kelime += kelime[i];
            }
        }
        return d_kelime;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int result = Result.alternate(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}