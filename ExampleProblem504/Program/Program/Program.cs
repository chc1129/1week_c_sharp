using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProbrem504
{
    class Program
    {
        static void Main(string[] args)
        {
            // インスタンス生成
            Ship ship = new Ship();
            BattleShip battleShip = new BattleShip();
            // 航行する
            ship.Sail();
            battleShip.Sail();
            // 戦闘する
            battleShip.Fight();
        }
    }
}