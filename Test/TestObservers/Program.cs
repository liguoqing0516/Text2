using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestObservers
{
   public class Program
    {
        static void Main(string[] args)
        {
            TenXun ten = new TenxunGame("腾讯游戏","天涯明月刀新职业上线等你来战");
            Subscriber subscriber = new Subscriber("张华丽");
            ten.action();
        }
    }
}
