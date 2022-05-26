
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static int minimumNumber(int n, string password)
    {
        string numbers = "0123456789";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string special_characters = "!@#$%^&*()-+";

        int count = 0;
        if (!numbers.ToCharArray().Any(password.Contains))
            count++;
        if (!lower_case.ToCharArray().Any(password.Contains))
            count++;
        if (!upper_case.ToCharArray().Any(password.Contains))
            count++;
        if (!special_characters.ToCharArray().Any(password.Contains))
            count++;
        return Math.Max(6 - n, count);
    }
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string password = Console.ReadLine();
        int answer = minimumNumber(n, password);
        Console.WriteLine(answer);
    }
}
