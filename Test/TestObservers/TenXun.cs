using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestObservers
{
    //委托充当订阅接口类
    public delegate void NotifyEventHandler(Object sender);
   
  public  class TenXun
    {
        public NotifyEventHandler NotifyEvent;
        public Action action;
       
        public String Symbol { get; set; }
        public string Info { get; set; }
        public TenXun(string symbol, string info)
        {
            this.Symbol = symbol;
            this.Info = info;
        }
        public void AddObserver2(Action ac)
        {
            action += ac;
        }

        public void AddObserver(NotifyEventHandler ob)
        {
            NotifyEvent += ob;
        }
        public void RemoveObserver(NotifyEventHandler ob)
        {
            NotifyEvent -= ob;
        }
        public void Update()
        {
            NotifyEvent?.Invoke(this);
        }
    }
}
