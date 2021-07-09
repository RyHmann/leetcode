using System;
using System.Text;

namespace CSharp.Solutions
{
    public class LongestCommonPrefix
    {
        public string GetLongestCommonPrefix(string[] strings)
        {
            if (strings.Length < 1)
            {
                return "";
            }
            char[] matchingChars = new char[0];
            string charactersToCheck = strings[0];
            int letterIncrementer = 0;
            int arrayIncrementer = 0;
            
            // index through array
            foreach (string word in strings)
            {
                // index through each nth character of each word
                // if index through entire array successful, add letter to matchingChars and continue to nextt characterToCheck
                while (arrayIncrementer < strings.Length)
                {
                    
                }
            }

            return new string(matchingChars).TrimEnd('\0');
        }
    }
}