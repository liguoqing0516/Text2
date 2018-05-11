using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
 public   class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartCPU();
            builder.BuilapartMainBoard();
        }
    }
}
