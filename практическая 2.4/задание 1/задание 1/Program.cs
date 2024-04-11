using System;
using System.Collections.Generic;

namespace задание_1
{
    class RomanNumerals
    {
        public int RomanToInt(string n)
        {
            Dictionary<char, int> RomanNum = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }

            };
            int result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (i < n.Length - 1 && RomanNum[n[i]] < RomanNum[n[i + 1]])
                {
                    result -= RomanNum[n[i]];
                }
                else
                {
                    result += RomanNum[n[i]];
                }
            }
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            RomanNumerals romanNumerals = new RomanNumerals();
            Console.WriteLine($"III = {romanNumerals.RomanToInt("III")}" );
        }
    }
}