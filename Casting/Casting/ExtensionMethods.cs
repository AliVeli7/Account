using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
    public static class ExtensionMethods
    {

        public static bool CustomContains(this string str, string word)
        {
            if (str.Contains(word))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CustomContains(this string str ,char element)
        {
            if (str.Contains(element))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPrime(this int num)
        {
            int i;
            for (i = 2; i <= num - 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            if (i == num)
            {
                return true;
            }
            return false;


        }
    }
}
