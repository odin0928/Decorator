using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_01.Componets
{
    abstract class 裝飾者:元件
    {
        protected 元件 被裝飾的東西;

        public 裝飾者(元件 想裝飾的東西)
        {
            this.被裝飾的東西 = 想裝飾的東西;
        }

        public override void Operation()
        {
            被裝飾的東西.Operation();
        }
    }
}
