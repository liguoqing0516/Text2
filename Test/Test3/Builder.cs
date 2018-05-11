using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    /// <summary>
    /// 抽象建造者.这个场景是为组装人
    /// </summary>
  public abstract  class Builder
    {
        /// <summary>
        /// 装CPu'
        /// </summary>
        public abstract void BuildPartCPU();
        /// <summary>
        /// 装主板
        /// </summary>
        public abstract void BuilapartMainBoard();
        /// <summary>
        /// 获得组装好的电脑
        /// </summary>
        /// <returns></returns>
        public abstract Computer GetComputer();
    }
}
