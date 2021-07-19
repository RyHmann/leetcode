using System;
using System.Text;

namespace CSharp.Solutions
{
    public class LongestCommonPrefix
    {
        public static string GetLongestCommonPrefix(string[] strings)
        {
            if (strings.Length < 1)
            {
                return "";
            }
            var stringBuilder = new StringBuilder();
            string charactersToCheck = strings[0];
            for (int i = 0; i < charactersToCheck.Length; i++)
            {
                int arrayIncrementer = 0;

                for (int j = 1; j < strings.Length; j++)
                {
                    if (i > strings[j].Length - 1)
                    {
                        return stringBuilder.ToString();
                    }
                    else if (charactersToCheck[i] != strings[j][i])
                    {
                        return stringBuilder.ToString();
                    }
                    arrayIncrementer++;
                }
                if (arrayIncrementer == strings.Length - 1)
                {
                    stringBuilder.Append(charactersToCheck[i]);
                }
            }
            return stringBuilder.ToString();
        }
    }
}