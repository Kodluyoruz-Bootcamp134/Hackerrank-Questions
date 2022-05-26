using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.ReadLine().Trim().Split(' ').Select(i => Convert.ToInt32(i)).OrderBy(i => i).ToList().ForEach(i => Console.Write("{0} ", i));
        }
    }
}
