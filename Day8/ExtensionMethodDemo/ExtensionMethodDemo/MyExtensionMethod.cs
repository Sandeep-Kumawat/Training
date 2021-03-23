using System;
using System.Collections.Generic;
using System.Text;
using CalculatorLib;
namespace ExtensionMethodDemo
{
    public static class MyExtensionMethod
    {
        public static int Mul(this Calculator c)
        {
            var res = c.Num1 * c.Num2;
            return res;
        }
        public static int wordCount(this String str)
        {
            var count = 0;
            var len = str.Length;
            for(int i=0;i<len;i++)
            {
                if(str[i]=='a'|| str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
