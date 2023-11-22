using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdoDemo
{
    public static class SortingService
    {

        public static int[] InsertionSort(int[] arr)
        {
            int n1 = arr.Length;
            int n2 = 0;
            for (int i = 1; i < n1; ++i)
            {
                int key = arr[i];
                n2 = i - 1;
                while (n2 >= 0 && arr[n2] > key)
                {
                    arr[n2 + 1] = arr[n2];
                    n2 = n2 - 1;
                }
                arr[n2 + 1] = key;
            }
            return arr;
        }

        public static int[] QuickSort(int[] arr, int begin, int end)
        {
            if (begin < end)
            {
                int partitionIndex = Partition(arr, begin, end);
                //Recursive
                QuickSort(arr, begin, partitionIndex - 1);
                QuickSort(arr, partitionIndex + 1, end);
            }
            return arr;
        }

        public static int Partition(int[] arr, int begin, int end)
        {
            int pivot = arr[end];
            int i = (begin - 1);
            int swapTemp = 0;
            for (int j = begin; j < end; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    swapTemp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = swapTemp;
                }
            }

            swapTemp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = swapTemp;

            return i + 1;
        }
    }
}

