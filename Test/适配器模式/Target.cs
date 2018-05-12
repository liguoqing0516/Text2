using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式
{
    /// <summary>
    /// 客户期待的接口或者抽象类
    /// </summary>
 public abstract   class Target
    {
        public abstract void Request();
    }
}
