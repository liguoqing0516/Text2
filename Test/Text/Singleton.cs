using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
  public  class Singleton
    {
        /// <summary>
        /// 定义一个静态变量来保存该类的实列
        /// </summary>
        private static Singleton uniqueInstance;

        //定义私有的构造函数不能被外界创建实列
        private Singleton()
        {
            
        }

        public static Singleton GetSingleton()
        {
            if (uniqueInstance==null)
            {
                uniqueInstance = new Singleton();
            }

            return uniqueInstance;
        }
    }
}
