using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestObservers
{
    /// <summary>
    /// 具体订阅者
    /// </summary>
   public  class Subscriber
    {
        public string Name { get; set; }
        public Subscriber(string name)
        {
            this.Name = name;
        }
        public void ReceiveAndPrint(Object obj)
             {
                 TenXun tenxun = obj as TenXun;

                 if (tenxun != null)
                 {
                     Console.WriteLine("Notified {0} of {1}'s" + " Info is: {2}", Name, tenxun.Symbol, tenxun.Info);
                 }            
             }
         }
}
