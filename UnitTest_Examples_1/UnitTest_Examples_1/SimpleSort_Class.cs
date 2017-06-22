using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Examples_1
{
    public static class SimpleSort_Class
    {
        public static char[] Simple_Sort(char[] input)
        {
            char k;
            int i = input.Length - 1;
            while (i > 0)
            {
                int j = 0;
                while (j < i)
                {
                    if (input[j] > input[i] - 1)
                    {
                        k = input[i];
                        input[i] = input[j];
                        input[j] = k;
                    }
                    j++;
                }
                i--;
            }
            return input;
        }
    }
}
