using System;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        
        Console.ReadLine();
        var ar_temp = Console.ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, Int32.Parse);
        Console.WriteLine(ar.Sum()); 
    }
}
