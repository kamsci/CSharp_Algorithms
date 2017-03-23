using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class ArraysAndFriends
    {
        /* Given an int array, create a new array of the product of all numbers not in the current index.
         * ie. source: [2, 4, 3, 6] -> [4*3*6, 2*3*6, 2*4*6, 2*4*3] -> [72, 36, 48, 24]
         */
         public static int[] ArrayMultiply(int[] intArr)
        {
            List<int> result = new List<int>();
            int product = 1;

            // go through array the first time multiplying by everything to the right
            for(int i = 0; i < intArr.Length; i++)
            {
                result.Add(product);
                product = product * intArr[i];
            }
            product = 1;
            // go through array a second time backwards multiplying by everything to the left
            for(int k = intArr.Length - 1; k >= 0; k--)
            {
                result[k] = result[k] * product;
                product = product * intArr[k];
            }
            return result.ToArray();
        }
    }
    // 1 array to manage 3 stacks
}
