using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 1424;
            //Console.WriteLine($"{x} {y}");
            //Console.WriteLine(x + " "+ y);


            Console.WriteLine($"{3} {1424}");
            Console.WriteLine(3 + 1424);

            /* int[] arr = new int[] { 1, 2, 3, 4, 5 };
             float[] arr2;
             arr2 = new float[10];
             for (int i = 0; i < 10; i++) {
                 arr2[i - 1] = i;
             }
             int j = 0;
             while ( j< 10)
             {
                 Console.WriteLine(arr2[j]);
                 j++;
             }*/
            x = 2;
            double[] arr = new double[6];
            for(int i = 0; i<6; i++)
            {
                arr[i] = Math.Pow(2, i + 1);
                Console.WriteLine(arr[i]);
            }
        }
    }
}
