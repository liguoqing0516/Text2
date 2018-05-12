using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式
{
    /// <summary>
    /// 适配器类
    /// </summary>
    public class Adapter : Target
    {
        private Adaptee adaptee;
        public override void Request()
        {
            if (adaptee!=null)
            {
                adaptee = new Adaptee();
            }
            adaptee.SpecificRequest();
        }
    }
}
