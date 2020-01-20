﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern1(); //This is a Pattern_1
            Console.WriteLine();
            pattern2(); //This is a Pattern_2
            Console.WriteLine();
            pattern3(); //This is a Pattern_3
            Console.WriteLine();
            Console.Read();
        }
        static void pattern1()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void pattern2()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void pattern3()
        {
            for (int i = 5; i>0; i--)
            {
                for (int j =5; j>0; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}