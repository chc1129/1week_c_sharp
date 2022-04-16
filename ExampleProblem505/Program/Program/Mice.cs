using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProblem505
{
    class Mice : Mammals
    {
        public Mice()
        {
            this.name = "ネズミ";
        }
        // 吠える
        public override void Bark()
        {
            Console.WriteLine("チューチュー");
        }
    }
}
