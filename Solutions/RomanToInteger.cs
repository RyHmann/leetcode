using System;
using System.Collections.Generic;

namespace CSharp.Solutions
{
    public class RomanToInteger
    {
        private Dictionary<char, int> NumeralChart = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        public int RomanToInt(string romanNumerals)
        {
            int numericValue = 0;

            for (int i = 0; i < romanNumerals.Length; i++)
            {
                char keyNumeral = romanNumerals[i];
                numericValue += NumeralChart[keyNumeral];
                if (i > 0)
                {
                    char previousNumeral = romanNumerals[i  - 1];
                    numericValue -= CheckSubtractCase(keyNumeral, previousNumeral);
                }
            }
            return numericValue;
        }

        private int CheckSubtractCase(char keyNumeral, char previousNumeral)
        {
            if (keyNumeral == 'V' || keyNumeral == 'X')
            {
                if (previousNumeral == 'I')
                {
                    return 2 * NumeralChart['I'];
                }
            }
            else if (keyNumeral == 'L' || keyNumeral == 'C')
            {
                if (previousNumeral == 'X')
                {
                    return 2 * NumeralChart['X'];
                }
            }
            else if (keyNumeral == 'D' || keyNumeral == 'M')
            {
                if (previousNumeral == 'C')
                {
                    return 2 * NumeralChart['C'];
                }
            }
            return 0;
        }
    }
}
