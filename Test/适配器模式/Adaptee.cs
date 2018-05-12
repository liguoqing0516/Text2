using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式
{
    /// <summary>
    /// 要适配的类
    /// </summary>
  public  class Adaptee 
    {
        public void SpecificRequest()
        {
            Console.WriteLine("执行要适配类的特殊要求");
        }
    }
}
