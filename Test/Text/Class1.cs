using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            //var s = new Square(10);
            //new Texts().Resize(s);

            Food food1 = FoodSimplaFactiory.CreateFood("西红柿炒鸡蛋");
            food1.print();
            Food food2 = FoodSimplaFactiory.CreateFood("土豆丝");
            food2.print();
            Console.ReadKey();

        }
    }
}
