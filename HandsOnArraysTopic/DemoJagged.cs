﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArraysTopic
{
    class DemoJagged
    {
        static void Main(String[] args)
        {
            string[][] names = new string[3][];
            for (int i= 0;i< 3;i++)
            {
                Console.WriteLine("enter the count in t"+(i+1));
                int size = int.Parse(Console.ReadLine());
                names[i] = new string[size];
            }
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < names[row].Length; col++)
                {

                    names[row][col] = Console.ReadLine();

                }
            }
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < names[row].Length; col++)
                {

                    Console.WriteLine(" "+names[row][col]);

                }
                Console.WriteLine();


            }
            foreach (string s in names[1])
                Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
