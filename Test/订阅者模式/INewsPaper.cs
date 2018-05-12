using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 订阅者模式
{
    /// <summary>
    /// 报纸接口
    /// </summary>
   public interface INewsPaper
    {
        /// <summary>
        /// 添加订阅者
        /// </summary>
        /// <param name="subscriber"></param>
        void RegisterSubscriber(ISubscriber subscriber);
        /// <summary>
        /// 取消订阅
        /// </summary>
        void RemovesScriber(ISubscriber subscriber);
        /// <summary>
        /// 发送报纸
        /// </summary>
        void Sendpaer();

    }
    /// <summary>
    /// 订阅者
    /// </summary>
    public interface ISubscriber
    {
        void HasNewpaer();
    }
}
