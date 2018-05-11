using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
   public class ConcreteBuilder2:Builder
    {
        Computer computer = new Computer();
        public override void BuilapartMainBoard()
        {
            computer.Add("cpu2");
        }

        public override void BuildPartCPU()
        {
            computer.Add("Main board2");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
