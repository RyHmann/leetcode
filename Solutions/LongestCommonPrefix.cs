using System;
using System.Text;

namespace CSharp.Solutions
{
    public class LongestCommonPrefix
    {
        public string GetLongestCommonPrefix(string[] strings)
        {
            char[] matchingChars = new char[strings[0].Length];
            string wordToCheck = strings[0];
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length < 1)
                {
                    return new string(matchingChars).TrimEnd('\0');
                }
                char charToCheck = wordToCheck[i];
                for (int j = 0; j < strings.Length; j++)
                {
                    if (wordToCheck.Length > strings[j].Length)
                    {
                        return new string(matchingChars).TrimEnd('\0');
                    }
                    else if (strings[j][i] != charToCheck)
                    {
                        return new string(matchingChars).TrimEnd('\0');
                    }
                }
                matchingChars[i] = charToCheck;
            }
            return new string(matchingChars).TrimEnd('\0');
        }
    }
}