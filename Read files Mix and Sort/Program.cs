using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Read_files_Mix_and_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\91970\Desktop\Files\text1.txt");

            string[] lines1 = File.ReadAllLines(@"C:\Users\91970\Desktop\Files\text2.txt");

            var mylist = new List<string>();
            mylist.AddRange(lines);
            mylist.AddRange(lines1);
            string[] a = mylist.ToArray();
            Array.Sort(a);

            foreach (string i in a)
            {
                Console.WriteLine(i);
             
            }
         
            Console.Read();
        }

    }
}
