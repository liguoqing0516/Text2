using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    /// <summary>
    /// 客户端测试版本
    /// </summary>
   public class Program
    {
        static void Main(string[] args)
        {
            Subscrilber subscrilber = new Subscrilber("王大山");
            TenXun tenxun = new TenxunGame("腾讯游戏", "有一个新的游戏发布上市了,快去试玩吧送VIP会员,等你来战??");
            tenxun.AddObaserver(subscrilber);
            tenxun.AddObaserver(new Subscrilber("王甜甜"));          
            tenxun.Update();
            Console.ReadLine();
        }
    }
}
