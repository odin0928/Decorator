using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTryIt.Componets
{
    abstract class 刀劍類:攻擊系元件
    {
        public int 鋒利度 { get; set; }
        public override void Operation()
        {
            Console.WriteLine("目前攻擊力{0}",this.鋒利度);
        }
    }
}
