using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Examples_1
{
    public static class MissingNumber
    {
        public static int[] GetMissingNumber(int[] input)
        {
            int maxNumber = input.Max();
            int count = input.Length;

            List<int> tempList = new List<int>(input);
            List<int> results = new List<int>();

            tempList.Sort();

            for (int i = 0; i < maxNumber; i++)
            {
                if (!tempList.Contains(i))
                    results.Add(i);
            }

            return results.ToArray<int>();
        }
    }
}
