using System;
using System.Collections.Generic;
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
            */
            // Two Sum
            var twoSummer = new TwoSum(InjectionTesting);
            int[] testArray = new int[]{2,7,11,15};
            int target = 9;
            int[] twoSumArray = twoSummer.getTwoSum(testArray, target);
            foreach(int sum in twoSumArray)
            {
                System.Console.WriteLine(sum);
            }
            /*

            // Palindrome
            int intToTest = 1223321;
            bool isPalindrome = Palindrome.IsPalindrome(intToTest);
            System.Console.WriteLine(isPalindrome);

            // RomanNumerals
            var numeralConverter = new RomanToInteger();
            string romanNumerals = "MCMXCIV";
            int romanValue = numeralConverter.RomanToInt(romanNumerals);
            System.Console.WriteLine(romanValue);
            

            string[] prefixTestArray = new string[]{"ab"};
            string longestCommonPrefix = LongestCommonPrefix.GetLongestCommonPrefix(prefixTestArray);
            System.Console.WriteLine($"Longest prefix: {longestCommonPrefix}");
            
            int n = 7;
            int solution = FibonacciCalculator.Fib(n);
            System.Console.WriteLine(solution);
            

            int[] candyTypes = new int[]{6, 6, 6, 6};
            int totalTypes = CandyCombinationCalculator.DistributeCandies(candyTypes);
            System.Console.WriteLine(totalTypes);
            */
            
            var listL1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            var listL2 = new ListNode(1, new ListNode(3, new ListNode(4)));

            var listMerger = new MergeLists();
            var solution = listMerger.MergeTwoLists(listL1, listL2);
            var solutionCursor = solution;
            while (solutionCursor != null)
            {
                System.Console.WriteLine(solutionCursor.val);
                solutionCursor = solutionCursor.next;
            }
            
        }
    }
}
