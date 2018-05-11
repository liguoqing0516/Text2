using System.Collections.Generic;

namespace Test3
{
    /// <summary>
    /// 电脑类
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// 电脑的集合
        /// </summary>
        private IList<string> parts = new List<string>();
        /// <summary>
        /// 把各个组件添加到电脑的集合
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            parts.Add(part);
        }
        /// <summary>
        /// 电脑组装的方法,相当于流水线
        /// </summary>
        public void Show()
        {
            System.Console.WriteLine("电脑开始组装");
            foreach (string item in parts)
            {
                System.Console.WriteLine("组件"+item+"已经装好");
            }
            System.Console.WriteLine("电脑已经装好");
        }
    }
}