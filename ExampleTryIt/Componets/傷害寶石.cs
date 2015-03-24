using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTryIt.Componets
{
    public class 傷害寶石 :攻擊系元件,裝飾者介面
    {
        攻擊系元件 被裝飾的東西;
        public 傷害寶石(攻擊系元件 想裝飾的東西)
        {
            this.被裝飾的東西 = 想裝飾的東西;
        }

        public override void Operation()
        {
            base.Operation();
            增加攻擊力();
        }

        public void 增加攻擊力()
        {
            被裝飾的東西.攻擊力 = 被裝飾的東西.攻擊力 + 100;
            this.攻擊力 = 被裝飾的東西.攻擊力;
            Console.WriteLine("攻擊力增加了{0},現在攻擊力是{1}", 100, 被裝飾的東西.攻擊力);
        }
    }
}
