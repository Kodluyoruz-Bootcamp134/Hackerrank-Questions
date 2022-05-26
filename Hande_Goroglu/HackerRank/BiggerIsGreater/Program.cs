
using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {

        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            char[] chr = Console.ReadLine().Trim().ToCharArray();
            int len = chr.Length;
            bool poss = false;
            int[] pos = new int[26];
            int idx = -1;
            int w = -1;
            bool[] small = new bool[26];
            small[(int)chr[len - 1] - (int)'a'] = true;
            pos[(int)chr[len - 1] - (int)'a'] = len - 1;
            for (int i = len - 2; i >= 0; i--)
            {
                int acode = (int)chr[i] - (int)'a';
                for (int j = acode + 1; j < 26; j++)
                {

                    if (small[j])
                    {
                        poss = true;
                        idx = pos[j];
                        break;
                    }
                }
                if (poss)
                {
                    w = i;
                    break;
                }
                small[acode] = true;
                pos[acode] = i;
            }
            
            if (poss)
            {
                char c = chr[w];
                chr[w] = chr[idx];
                chr[idx] = c;
                char[] sortarr = new char[len - w - 1];
                int counter = 0;
                for (int i = w + 1; i < len; i++)
                {
                    sortarr[counter] = chr[i];
                    counter++;
                }
                Array.Sort(sortarr);
                for (int i = 0; i < sortarr.Length; i++)
                {
                    chr[w + 1] = sortarr[i];
                    w++;
                }
                Console.WriteLine(new string(chr));
            }
            else
            {
                Console.WriteLine("no answer");
            }
        }
    }
}
