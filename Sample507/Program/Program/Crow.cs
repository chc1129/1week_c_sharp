﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample507
{
    // カラスクラス
    class Crow
    {
        private String name = "カラス";
        // カラスがなく
        public void Sing()
        {
            Console.WriteLine("カーカー");
        }
        // 名前を取得
        public String Name
        {
            get { return name; }
        }
    }
}
