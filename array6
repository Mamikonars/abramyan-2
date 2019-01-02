using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public static int ArraySum(int[] arr) {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                 sum += arr[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int a = 1, b = 2, n = 10;
            int[] arr = new int[n];
            arr[0] = a;
            arr[1] = b;
            for(int i=2; i<n; i++){
                arr[i] = ArraySum(arr);
            }
            foreach (int k in arr) {
                Console.WriteLine(k);
            }
            
          
            Console.ReadKey();
        }
    }
}
