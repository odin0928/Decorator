using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example_01.Componets;
namespace Example_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            元件 滅絕師太的倚天劍 = new 倚天劍();
            元件 滅絕師太的黃金鎧甲 = new 黃金鎧甲();

            滅絕師太的倚天劍.Operation();
            滅絕師太的倚天劍 = new 閃電寶石(滅絕師太的倚天劍);
            滅絕師太的倚天劍.Operation();
            滅絕師太的倚天劍 = new 閃電寶石(滅絕師太的倚天劍);
            滅絕師太的倚天劍.Operation();
        }
    }
}
