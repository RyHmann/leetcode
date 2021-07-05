using System;

namespace CSharp.Solutions
{
    public class ReverseInteger 
        {
            bool isNegative = false;
            public int ReverseInt(int intToReverse) 
            {
                if (intToReverse < 0)
                {
                    isNegative = true;
                    intToReverse = intToReverse * -1;
                }
                int[] intArray = PopulateArray(intToReverse);
                int reversedInt = CreateIntFromArray(intArray);
                if (isNegative == true)
                {
                    return reversedInt * -1;
                }
                else
                {
                    return reversedInt;
                }
            }

            private int[] CreateArray(int intToReverse)
            {
                int incrementor = 0;
                while (intToReverse > 0)
                {
                    intToReverse = intToReverse / 10;
                    incrementor ++;
                }
                int[] intArray = new int[incrementor];
                return intArray;
            }

            private int[] PopulateArray(int intToReverse)
            {
                int[] intArray = CreateArray(intToReverse);
                int incrementor = 0;
                while (intToReverse > 0)
                {
                    int remainder = intToReverse % 10;
                    intArray[incrementor] = remainder;
                    incrementor++;
                    intToReverse = intToReverse / 10;
                }
                return intArray;
            }

            private int CreateIntFromArray(int[] intArray) {
                int reversedInt = 0;
                int incrementer = 0;
                foreach (var num in intArray)
                {
                    double exponent = (intArray.Length - 1) - incrementer;
                    int tensPlace = 0;
                    if (num * Math.Pow(10, exponent) >= Math.Pow(2, 32) / 2 - 1)
                    {
                        return 0;
                    }
                    else
                    {
                        tensPlace = Convert.ToInt32(Math.Pow(10, exponent));
                    }
                    if (reversedInt + num * tensPlace < 0)
                    {
                        return 0;
                    }
                    else
                    {
                        reversedInt = reversedInt + num * tensPlace;
                    }
                    incrementer++;
                }
                return reversedInt;
            }
        }
}
