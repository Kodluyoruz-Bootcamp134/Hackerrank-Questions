using System;
class Solution
{
    static void Main(string[] args)
    {
        var alphabetCount = 26;
        var alphabetOccurenceTrack = new int[26];
        var nextChar = Console.Read();
       
        while (nextChar != -1)
        {
            if (nextChar >= 97 && nextChar <= 122)
            {
                var arrIndex = nextChar - 97;
                if (alphabetOccurenceTrack[arrIndex] == 0)
                {
                    
                    alphabetCount--;
                    alphabetOccurenceTrack[arrIndex] = 1;
                }

            }

            if (nextChar >= 65 && nextChar <= 90)
            {
                var arrIndex = nextChar - 65;
                if (alphabetOccurenceTrack[arrIndex] == 0)
                {
                    
                    alphabetCount--;
                    alphabetOccurenceTrack[arrIndex] = 1;
                }

            }

            if (alphabetCount == 0)
                break;

            nextChar = Console.Read();
        }

        if (alphabetCount > 0)
            Console.WriteLine("not pangram");
        else
            Console.WriteLine("pangram");
    }
}
