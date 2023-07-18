//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MergeSortedArray
//{
//    public class Program
//    {
//        public static void mergeArrays(int[] arr1, int[] arr2, int n1, int n2, int[] arr3)
//        {
//            int i = 0;
//            int j = 0;
//            int k = 0;

//            // traverse the arr1 and insert its element in arr3
//            while (i < n1)
//            {
//                arr3[k++] = arr1[i++];
//            }

//            // now traverse arr2 and insert in arr3
//            while (j < n2)
//            {
//                arr3[k++] = arr2[j++];
//            }

//            // sort the whole array arr3
//            Array.Sort(arr3);
//        }

//        public static void Main(string[] args)
//        {
//            int[] arr1 = new int[] { 1, 3, 5, 7 };
//            int n1 = arr1.Length;

//            int[] arr2 = new int[] { 2, 4, 6, 8 };
//            int n2 = arr2.Length;

//            int[] arr3 = new int[n1 + n2];
//            mergeArrays(arr1, arr2, n1, n2, arr3);

//            Console.WriteLine("Array after merging");
//            for (int i = 0; i < n1 + n2; i++)
//                Console.Write(arr3[i] + " ");
//        }
//    }
//}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeProblems
{
    class program
    {
        public static void mergeArrays(int[] arr1, int[] arr2, int n1, int n2, int[] arr3)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            // traverse the arr1 and insert its element in arr3
            while (i < n1)
            {
                arr3[k++] = arr1[i++];
            }

            // now traverse arr2 and insert in arr3
            while (j < n2)
            {
                arr3[k++] = arr2[j++];
            }

            // sort the whole array arr3
            Array.Sort(arr3);
        }

        public static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 3, 5, 7 };
            int n1 = arr1.Length;

            int[] arr2 = new int[] { 2, 4, 6, 8 };
            int n2 = arr2.Length;

            int[] arr3 = new int[n1 + n2];
            mergeArrays(arr1, arr2, n1, n2, arr3);

            Console.WriteLine("Array after merging");
            for (int i = 0; i < n1 + n2; i++)
                Console.Write(arr3[i] + " ");
        }
    }
}
