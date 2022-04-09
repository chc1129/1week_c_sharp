﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample210
{
    class Program
    {
        static void Main(string[] args)
        {
            //  サイコロの目を入力
            Console.Write("さいころの目(1～6):");
            //  コンソールから数値を入力
            int dice = int.Parse(Console.ReadLine());
            //  値が、サイコロの目の範囲内かどうかを調べる
            if (1 <= dice && dice <= 6)
            {
                //  サイコロの目が、偶数か、奇数かで、処理を分ける。
                if (dice == 2 || dice == 4 || dice == 6)
                {
                    //  偶数ならば丁（チョウ）
                    Console.WriteLine("丁（チョウ）です。");
                }
                else
                {
                    //  奇数ならば半（ハン）
                    Console.WriteLine("半（ハン）です。");
                }
            }
            else
            {
                Console.WriteLine("範囲外の数値です。");
            }
        }
    }
}