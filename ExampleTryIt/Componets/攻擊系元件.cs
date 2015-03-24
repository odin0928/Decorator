using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTryIt.Componets
{
    public abstract class 攻擊系元件:元件介面
    {
        public int 攻擊力 { get; set; }

        public virtual void Operation()
        {

        }
    }
}
