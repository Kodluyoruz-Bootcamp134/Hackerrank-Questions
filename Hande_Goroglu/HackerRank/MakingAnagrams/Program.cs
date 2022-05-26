
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections;
namespace Rextester
{
    public class Program
    {
        private void MyMethod(Dictionary<char, int> myDictionary)
        {



        }

        public static void Main(string[] args)
        {
           
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            char[] aO = a.Trim().Replace(" ", "").ToLower().ToCharArray();
            Array.Sort(aO);

            char[] bO = b.Trim().Replace(" ", "").ToLower().ToCharArray();
            Array.Sort(bO);


            ArrayList aOrignal = new ArrayList();
            aOrignal.AddRange(aO);

            ArrayList bOrignal = new ArrayList();
            bOrignal.AddRange(bO);

            Dictionary<char, int> aDic = new Dictionary<char, int>();
            foreach (char item in aOrignal)
            {

                if (aDic.ContainsKey(item))
                    aDic[item]++;
                else
                    aDic.Add(item, 1);
            }


            Dictionary<char, int> bDic = new Dictionary<char, int>();
            foreach (char item in bOrignal)
            {
                if (bDic.ContainsKey(item))
                    bDic[item]++;
                else
                    bDic.Add(item, 1);
            }

            ArrayList confirm = new ArrayList();


            foreach (KeyValuePair<char, int> kvp in aDic.ToList())
            {
                if (aOrignal.Contains(kvp.Key) && bOrignal.Contains(kvp.Key))
                {
                    aDic[kvp.Key] -= 1;
                    bDic[kvp.Key] -= 1;
                    for (var i = 1; i < kvp.Value; i++)
                    {
                        if (aDic.ContainsKey(kvp.Key) && bDic.ContainsKey(kvp.Key))
                        {
                            if (aDic[kvp.Key] > 0 && bDic[kvp.Key] > 0)
                            {
                                aDic[kvp.Key] -= 1;
                                bDic[kvp.Key] -= 1;
                            }
                        }
                    }



                }
                            

            }
            int count = 0;
            foreach (KeyValuePair<char, int> kvp in bDic)
            {
                count += kvp.Value;
                             

            }
            foreach (KeyValuePair<char, int> kvp in aDic)
            {
                count += kvp.Value;
                             

            }

            Console.WriteLine(count);

            
        }
    }
}
