using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    /// <summary>
    /// 具体创建者,具体毛个人为具体创建者,列如是小王,就是具体是谁装的 相当于装配工
    /// </summary>
    public class ConcreteBuilder1 : Builder
    {

        Computer computer = new Computer();
        //装备cpu
        public override void BuilapartMainBoard()
        {
            computer.Add("cpu1");
        }
        //装配主板
        public override void BuildPartCPU()
        {
            computer.Add("Main board1");
        }
        //返回一个电脑
        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
