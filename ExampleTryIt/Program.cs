using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleTryIt.Componets;
namespace ExampleTryIt
{
    class Program
    {
        static void Main(string[] args)
        {
            攻擊系元件 滅絕師太的倚天劍 = new 倚天劍();
            滅絕師太的倚天劍.Operation();
            //滅絕師太的倚天劍 = new 閃電寶石(滅絕師太的倚天劍);
            滅絕師太的倚天劍 = new 傷害寶石(滅絕師太的倚天劍);
            滅絕師太的倚天劍.Operation();
            滅絕師太的倚天劍 = new 傷害寶石(滅絕師太的倚天劍);
            滅絕師太的倚天劍.Operation();
            //元件 滅絕師太的黃金鎧甲 = new 黃金鎧甲();
            //滅絕師太的黃金鎧甲 = new 堅固寶石(滅絕師太的黃金鎧甲);
            //滅絕師太的黃金鎧甲.Operation();

        }
    }
}
