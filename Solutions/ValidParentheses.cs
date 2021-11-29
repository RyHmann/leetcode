using System;

namespace CSharp.Solutions
{
    class ValidParentheses
    {
        private int bracketCounter = 0;
        private int parenthesesCounter = 0;
        private int curlyBracketCounter = 0;

        public static bool IsValidParentheses(string testString)
        {
            throw NotImplementedException();
        }

        private static void ParanthesesIncrementor(char bracket)
        {
            switch (bracket)
            {
                case == '[':
                    bracketCounter += 1;
                    break;
                case == '(':
                    parenthesesCounter += 1;
                    break;
                case == '{':
                    curlyBracketCounter += 1;
                    break;
                case == ']':
                    bracketCounter -= 1;
                    break;
                case == ')':
                    parenthesesCounter -= 1;
                    break;
                case == '}':
                    curlyBracketCounter -= 1;
                default:
                    Console.WriteLine("Invalid character.");
                    break;
            }
        }
    }
}