using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTryIt.Componets
{
    public class 閃電寶石:裝飾者
    {
        public 閃電寶石(元件 被裝飾的武器)
            : base(被裝飾的武器) { }

        public override void Operation()
        {
            base.Operation();
            this.放閃電();
        }
        
        public void 放閃電()
        {
            Console.WriteLine("施放了閃電");
        }
    }
}
