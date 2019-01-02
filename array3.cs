using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, a = 7, d = 5;
            int[] arr = new int[n];
             
            for(int i=0, j=a; i<n; i++, j+=d){             
                arr[i] = j;
            }
            foreach (int k in arr) {
                Console.WriteLine(k);
            }             
            Console.ReadKey();
        }
    }
}
