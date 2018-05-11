

namespace Test4
{
    using System.Collections;
    /// <summary>
    /// 具体的订阅者类
    /// </summary>'
    /// 
    public class Subscrilber:IObservable
    {
        /// <summary>
        /// 订阅者的名字
        /// </summary>
        public string Name { get; set; }
        public Subscrilber(string name)
        {
            this.Name = name;
        }   
        /// <summary>
        /// 使用订阅号对象来通知订阅者的消息
        /// </summary>
        /// <param name="tenXun"></param>
        public void ReceiveAndPrint(TenXun tenXun)
        {
            System.Console.WriteLine("Notified{0} of{1} s" + "Info is:{2}", Name, tenXun.Symbol, tenXun.Info);
        }
    }
}