using System;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            List<int> list = new List<int>();

            for (int i = 0; i <= arr.Length; i++)
            {
                list.Add(i);
            }
            Console.WriteLine("Hello World!");
            /* string str = "Romanenko Timofy 19.09.2020";
            // Console.WriteLine(str[i]);
            int i = 1;
             while (i < 21) 
             {
                 Console.Write(i+" ");
                 i += 4;
             } 
             */
            /*int j = 0;
            do{
                Console.Write(j + " ");
                j += 5;
            }while (j < 21) ;*/

        }
    }
}
