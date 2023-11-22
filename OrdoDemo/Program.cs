
using System.Diagnostics;

namespace OrdoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr = GenerateArray();
            
            Stopwatch sw = Stopwatch.StartNew();
            int[] quickArr = SortingService.QuickSort(arr, 0, arr.Length - 1);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            int[] arr2 = GenerateArray();
            Stopwatch sw2 = Stopwatch.StartNew();
            int[] sortArr = SortingService.InsertionSort(arr2);
            sw2.Stop();
            Console.WriteLine(sw2.Elapsed);
            
        }

        private static int[] GenerateArray()
        {
            int limit = 10000000;
            Random random = new Random();
            int[] arr = new int[limit];
            for (int i = 0; i < limit ; i++)
            {
                arr[i] = random.Next(0,1000);
            }
            return arr;
        }
    }
}
