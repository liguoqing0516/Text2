using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 订阅者模式
{
 public  class Program
    {
        static void Main(string[] args)
        {
            PeopleNewsPaper people = new PeopleNewsPaper();
            SubHuman sub = new SubHuman("小米");
            people.RegisterSubscriber(sub);
            people.Sendpaer();
            Console.ReadKey();
        }
    }
}
