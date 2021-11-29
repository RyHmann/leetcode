using System;

namespace CSharp.Solutions
{
    public class ValidParentheses
    {
        private int bracketCounter = 0;
        private int parenthesesCounter = 0;
        private int curlyBracketCounter = 0;
        private char[] charArray;

        public ValidParentheses(string stringToTest)
        {
            charArray = stringToTest.ToCharArray();
        }

        public bool IsValidParentheses()
        {
            bool isValid = false;
            foreach (var charToCheck in charArray)
            {
                IncrementCounters(charToCheck);
            }
            if (bracketCounter == 0 && parenthesesCounter == 0 && curlyBracketCounter == 0)
            {
                isValid = true;
            }
            return isValid;
        }

        private void IncrementCounters(char bracket)
        {
            if (bracket == '[')
            {
                bracketCounter += 1;
            }
            else if (bracket == ']')
            {
                bracketCounter -= 1;
            }
            else if (bracket == '{')
            {
                curlyBracketCounter += 1;
            }
            else if (bracket == '}')
            {
                curlyBracketCounter -= 1;
            }
            else if (bracket == '(')
            {
                parenthesesCounter += 1;
            }
            else if (bracket == ')')
            {
                parenthesesCounter -= 1;
            }
        }
    }
}