using System;
using System.Collections.Generic;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> l = new List<string>(){"Укр.м"," алгебра", "геометрия", "заруб.л", "рус.яз" };

            foreach(string s in l)
            {
                Console.Write(s);
            }

            Console.WriteLine(l.Count);

            l.Clear();

            Console.WriteLine("Hello World!");
        }
    }
}
             