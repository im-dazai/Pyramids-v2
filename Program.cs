using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramids_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i, n, j;
            //n = 5;
            //i = 1;
            //while (i <= n) // Rows - This loop will just create rows.
            //{
            //    j = i;
            //    while (j <= n) // Columns - This loop will print something inside those rows.
            //    {
            //        Console.Write("# ");
            //        j++;
            //    }
            //    i++;
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            int a, b, c, d;
            a = 5;
            b = 1;
            while (b <= a)
            {
                // For Left Triangle
                c = b;
                while (c <= a)
                {
                    Console.Write("  ");
                    c++;
                }
                // For Right Triangle
                d = 1;
                while (d < b)
                {
                    Console.Write("$ ");
                    d++;
                }
                d = 1;
                while (d <= b)
                {
                    Console.Write("$ ");
                    d++;
                }
                Console.WriteLine();
                b++;
            }

            Console.ReadLine();


            // Upper Triangle
            //int x, y, z, a;

            //x = 10;
            //y = 1;
            //a = 1;
            //while (y < x)
            //{
            //    z = y;
            //    while (z <= x)
            //    {
            //     Console.Write("  ");
            //        z++;
            //    }


            //    a = 1;
            //    while (a < y)
            //    {
            //        Console.Write("# ");
            //        a++;
            //    }

            //    a = 1;
            //    while (a <= y)
            //    {
            //        Console.Write("# ");
            //        a++;
            //    }
            //    Console.WriteLine();    
            //    y++;




            //}

            //// Lower Triangle

            //x = 10;
            //y = 1;
            //while (y <= x)
            //{
            // a = 1;
            //    while (a <= y)
            //    {
            //        Console.Write("  ");
            //        a++;
            //    }

            //    z = y;
            //    while (z < x)
            //    {
            //        Console.Write("# ");
            //        z++;
            //    }

            //    z = y;
            //    while (z <= x)
            //    {
            //        Console.Write("# ");
            //        z++;
            //    }

            //    Console.WriteLine();
            //    y++;
            //}

            //Console.ReadLine();


















        }
    }
}
