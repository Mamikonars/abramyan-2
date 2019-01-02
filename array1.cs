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
            int n = 10;
            int[] arr = new int[n];             
            for(int i=0, j=1; i<n; i++, j+=2){             
                arr[i] = j;
            }
            foreach (int k in arr) {
                Console.WriteLine(k);
            }             
            Console.ReadKey();
        }
    }
}
