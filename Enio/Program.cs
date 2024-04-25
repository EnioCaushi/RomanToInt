using System;
using System.Collections.Generic;

public class Solution
{
    public static int RomanToInt(string s)
    {
        Dictionary<char, int> mymap = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        int value = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && mymap[s[i]] < mymap[s[i + 1]])
                value -= mymap[s[i]];
            else
                value += mymap[s[i]];
        }
        return value;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Shkruaj numrin romak:");
        string input = Console.ReadLine().ToUpper(); 
        int result = RomanToInt(input);
        Console.WriteLine("Numri i plote eshte: " + result);
    }
}
