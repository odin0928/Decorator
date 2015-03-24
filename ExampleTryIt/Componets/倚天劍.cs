using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTryIt.Componets
{
    class 倚天劍:刀劍類
    {
        public 倚天劍()
        {
            this.攻擊力 = 500;
        }
        public override void Operation()
        {
            Console.WriteLine("這是滅絕師太的寶劍,攻擊力{0}",this.攻擊力.ToString());
        }
    }
}
