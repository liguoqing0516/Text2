using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 订阅者模式
{
    public class SubHuman : ISubscriber
    {
        private string name;
        public SubHuman(string Name)
        {
            this.name = Name;
        }
        public void HasNewpaer()
        {
            Console.WriteLine(name+"亲新报纸发布了,快来拿吧");
        }
    }
}
