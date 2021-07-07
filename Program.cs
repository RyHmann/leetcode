﻿using System;
using CSharp.Solutions;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Reverse Integer
            var numReverser = new ReverseInteger();
            int testInt = 1534236469;
            System.Console.WriteLine($"Initial number: {testInt}");
            int reversedInt = numReverser.ReverseInt(testInt);
            Console.WriteLine($"Final number: {reversedInt}");

            // Two Sum
            var twoSummer = new TwoSum();
            int[] testArray = new int[]{2,7,11,15};
            int target = 9;
            int[] twoSumArray = twoSummer.getTwoSum(testArray, target);
            foreach(int sum in twoSumArray)
            {
                System.Console.WriteLine(sum);
            }

            // Palindrome
            var palindromeTester = new Palindrome();
            int intToTest = 1223321;
            bool isPalindrome = palindromeTester.IsPalindrome(intToTest);
            System.Console.WriteLine(isPalindrome);
            */

            var numeralConverter = new RomanToInteger();
            string romanNumerals = "MCMXCIV";
            int romanValue = numeralConverter.RomanToInt(romanNumerals);
            System.Console.WriteLine(romanValue);
        }
    }
}