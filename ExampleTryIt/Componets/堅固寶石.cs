using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTryIt.Componets
{
    public class 堅固寶石 : 裝飾者
    {
        public 堅固寶石(元件 被裝飾的防具)
            :base(被裝飾的防具){}

        public override void Operation()
        {
            base.Operation();
            this.強化();
        }

        public void 強化()
        {
            Console.WriteLine("變得更堅固了");
        }
    }
}
