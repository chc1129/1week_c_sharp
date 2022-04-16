using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem505
{
    class Cat : Mammals
    {
        public Cat()
        {
            this.name = "猫";
        }
        // 吠える
        public override void Bark()
        {
            Console.WriteLine("ニャーニャー");
        }
    }
}
