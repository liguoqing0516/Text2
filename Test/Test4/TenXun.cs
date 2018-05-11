using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
   public abstract class TenXun
    {
        private List<IObservable> observables = new List<IObservable>();
        public String Symbol { get; set; }
        public string Info { get; set; }
        public TenXun(string symbol,string info)
        {
            this.Symbol = symbol;
            this.Info = info;
        }
        /// <summary>
        /// 添加一个订阅者
        /// </summary>
        /// <param name="observable"></param>
        public void AddObaserver(IObservable observable)
        {
            observables.Add(observable);
        }
        /// <summary>
        /// 删除一个订阅者
        /// </summary>
        /// <param name="observable"></param>
        public void RemoveObserver(IObservable observable)
        {
            observables.Remove(observable);
        }
        public void Update()
        {
            //遍历订阅者对象列表进行通知
            foreach (var item in observables)
            {
                if (item!=null)
                {
                    TenXun tenXun = this;
                    item.ReceiveAndPrint(tenXun);
                }
            }
        }

    }
    /// <summary>
    /// 订阅者实现通知的具体方法
    /// </summary>
      public interface IObservable
    {
        void ReceiveAndPrint(TenXun tenXun);
    }
}
