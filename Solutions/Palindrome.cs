using System;

namespace CSharp.Solutions
{
    public class Palindrome
    {
        public bool IsPalindrome(int x) 
        {
            if (x < 0)
            {
                return false;
            }
            int[] intArray = ConvertIntToArray(x);
            for (int i = 0; i < intArray.Length / 2; i++)
            {
                if (intArray[i] != intArray[(intArray.Length - 1) - i])
                {
                    return false;
                }
            }
            return true;
        }

        private int[] CreateShellArray(int palindromeInt)
        {
            int incrementer = 0;
            while (palindromeInt > 0)
            {
                palindromeInt = palindromeInt / 10;
                incrementer++;
            }
            return new int[incrementer];
        }

        private int[] ConvertIntToArray(int palindromeInt)
        {
            int[] intArray = CreateShellArray(palindromeInt);
            int incrementer = 0;
            while (palindromeInt > 0)
            {
                int remainder = palindromeInt % 10;
                intArray[incrementer] = remainder;
                incrementer++;
                palindromeInt = palindromeInt / 10;
            }
            return intArray;
        }
    }
}