using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
  public  class Program
    {
     public   static void Main(string[] args)
        {
            //第一步创建一个指挥者
            Director director = new Director();
            //为装配工人,创建接口,相当于工具和方法
            Builder builder1 = new ConcreteBuilder1();   
            //指挥者要让工人组装一个电脑
            director.Construct(builder1);
            //工人去组装一个电脑,一个电脑组装好了
            Computer computer1 = builder1.GetComputer();
            //把电脑拿给指挥看
            computer1.Show();
            Console.ReadKey();
        }
    }
}
