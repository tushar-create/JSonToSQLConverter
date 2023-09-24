using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet
{
    internal class RemoveDuplicates
    {
        public int deleteDuplicates(int[] sortedArray)
        {
            if (sortedArray == null || sortedArray.Length == 0)
                return sortedArray.Length;

            int n = sortedArray.Length;
            int[] uniqueArray = new int[n];
            int currentUniqueIndex = 0;

            uniqueArray[currentUniqueIndex++] = sortedArray[0];

            for (int i = 1; i < n; i++)
            {
                if (sortedArray[i] != sortedArray[i - 1])
                {
                    uniqueArray[currentUniqueIndex++] = sortedArray[i];
                }
            }

            // Trim the uniqueArray to the correct length (currentUniqueIndex)
            Array.Resize(ref uniqueArray, currentUniqueIndex);

            return uniqueArray.Length;
        }
    }
}
