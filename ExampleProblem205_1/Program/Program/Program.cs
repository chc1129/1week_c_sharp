﻿using System;

namespace ExampleProblem205_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  文字列を入力
            Console.Write("文字列を入力:");
            string s = Console.ReadLine();
            if (s == "Hello")
            {
                Console.WriteLine("Helloが入力されました。");
            }
            else
            {
                Console.WriteLine("Helloと入力して下さい。");
            }
        }
    }
}