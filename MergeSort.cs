using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet
{
    public class MergeSort
    {
        public int[] MergeSortResult(int[] arr)
        {
            int l = 0,h=arr.Length;
            int[] fin= sort(arr,l,h);

            return fin;
        }

        //private int[] MergeCall(int[] arr,int l,int r)
        //{
        //    for (int i=l < r)
        //    {
        //        // Find the middle
        //        // point
        //        int m = l + (r - l) / 2;

        //        // Sort first and
        //        // second halves
        //        //sort(arr, l, m);
        //        //sort(arr, m + 1, r);

        //        // Merge the sorted halves
        //        Merge(arr, l, m, r);
        //    }
        //}
        private int[] Merge(int[] arr, int l,int mid, int h)
        {
            int i = l, j = mid + 1, k = h;
            while (i <=mid && j<=mid)
            {
                if(arr[i] <= arr[j])
                {
                    arr[k] = arr[i];
                    i++;
                }
                else
                {
                    arr[k] = arr[j];
                    j++;
                }
                k++;
            }

            if(i>mid)
            {
                while(j<=h)
                {
                    arr[k++] = arr[j++];  
                }
            }
            else
            {
                while (i <= mid)
                {
                    arr[k++] = arr[i++];
                }
            }
            return arr;
        }

        private static int[] sort(int[] arr,int l,int h)
        {
            if (l < h)
            {
                int mid = l + h / 2;
                sort(arr,l, mid); 
                sort(arr,h, mid);
            }
            return arr;
        }
    }
}
