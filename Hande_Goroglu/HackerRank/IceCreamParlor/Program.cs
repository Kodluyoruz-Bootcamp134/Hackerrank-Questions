using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{

    static int[] IcecreamParlor(int totalMoney, int[] icecreamPrices)
    {
        var boughtIcreamIndexes = new int[2];
        var lookup = new Dictionary<int, int>();
        for (var i = 0; i < icecreamPrices.Length; i++)
        {
            if (icecreamPrices[i] < totalMoney)
            {
                var otherIceCreamPrice = totalMoney - icecreamPrices[i];
                if (lookup.ContainsKey(otherIceCreamPrice))
                {

                    var indexOfOtherIcecream = lookup[otherIceCreamPrice];
                    if (indexOfOtherIcecream < i)
                    {
                        boughtIcreamIndexes[0] = indexOfOtherIcecream + 1;
                        boughtIcreamIndexes[1] = i + 1;
                    }
                    else
                    {
                        boughtIcreamIndexes[0] = i + 1;
                        boughtIcreamIndexes[1] = indexOfOtherIcecream + 1;
                    }
                    break;
                }
                else
                {
                    if (!lookup.ContainsKey(icecreamPrices[i]))
                        lookup.Add(icecreamPrices[i], i);
                }
            }
        }
        return boughtIcreamIndexes;
    }

    static void Main(String[] args)
    {
        var t = int.Parse(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            var m = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();
            var arr_temp = Console.ReadLine().Split(' ');
            var arr = Array.ConvertAll(arr_temp, int.Parse);

            var result = IcecreamParlor(m, arr);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

