using Leet;

public class Solution
{
    public static void Main(string[] args)
    {

        RemoveDuplicates removeDuplicates = new RemoveDuplicates();
        int[] in_Array = {1, 1, 1, 2, 2, 3};

        int res = removeDuplicates.deleteDuplicates(in_Array);

        GrayCode grayCode = new GrayCode();

        Console.WriteLine(grayCode.ConvertDecimalToBinary(8));
        
        //int[] ints = { 1, 2, 3, 4, 5, 7 };
        //MergeSort mergeSort = new MergeSort();
        //BinarySearch binarySearch = new BinarySearch();
        //int res= binarySearch.Search(ints, 5);

        //int[] ints = { 1, 3, 5, 0, 0, 0 };
        //int[] ints1 = { 2, 4, 6 };
        //MergeSortedArray mergeSortedArray = new MergeSortedArray();
        //int[] fin = mergeSortedArray.Merge(ints, ints1, 3, 3);

        ////foreach (var item in fin)
        ////{
        ////    Console.WriteLine(item + ",");
        ////}
        ///
        //Add2Integers add2Integers = new Add2Integers();
        //int[] ints = { 2, 7, 11, 15 };
        //int[] res = add2Integers.TwoSum(ints,17);

        Console.WriteLine("Press any key to continue. . .");
        Console.ReadKey();
    }
    
    
}