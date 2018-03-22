using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using MoreLinq;

namespace TextModifer
{

    class Program
    {



    public static String path = @"F:\1.txt";
    public static String path2 = @"F:\2.txt";
        static void Main(string[] args)
        {

            // Delete blank lines from file
            // Delete blank lines from file
            var lines = System.IO.File.ReadAllLines(path).Where(arg => !string.IsNullOrWhiteSpace(arg));
            System.IO.File.WriteAllLines(path, lines);
          

            var stringsPairs = File.ReadLines(path).Batch(2).Select(p => string.Join("\n @ " , p));

            File.WriteAllLines(path2, stringsPairs, Encoding.UTF8);

        }



        static void oldMain()
        {


        }

        public static void Linecount()
        {
            int count = System.IO.File.ReadAllLines(path).Length;
            Console.WriteLine(count);
        }

        public static void Chetnie()
        {
            string[] lines = File.ReadAllLines(path);
            int n = 1;
            while (n < lines.Length)
            {
                Console.WriteLine(lines[n]);
                n += 2;
            }
            Console.ReadKey();
        }
    }
}
