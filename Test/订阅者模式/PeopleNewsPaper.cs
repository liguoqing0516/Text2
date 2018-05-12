using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 订阅者模式
{
    /// <summary>
    /// 人民日报
    /// </summary>
    public class PeopleNewsPaper : INewsPaper
    {
        private List<ISubscriber> subList = new List<ISubscriber>();
        public void RegisterSubscriber(ISubscriber subscriber)
        {
            subList.Add(subscriber);
        }
        //删除订阅者
        public void RemovesScriber(ISubscriber subscriber)
        {
            if (subList.Contains(subscriber))
            {
                subList.Remove(subscriber);
            }
        }

        public void Sendpaer()
        {
            foreach (ISubscriber item in subList)
            {
                item.HasNewpaer();
            }
        }
    }
}
