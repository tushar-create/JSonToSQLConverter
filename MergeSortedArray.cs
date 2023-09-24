using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet
{
    public class MergeSortedArray
    {
        public int[] Merge(int[] a1, int[] a2, int m, int n)
        {
            int i = m + n - 1;
            int[] fin= new int[i];
            int p1 = m - 1;
            int p2 = n - 1;

            while (p2>=0)
            {
                if (p1>=0 &&  a1[p1] > a2[p2])
                {
                    a1[i--] = a1[p1--];
                }
                else
                {
                    a1[i--] = a2[p2--];
                }
            }

            
            return a1;
        }

    }
}
