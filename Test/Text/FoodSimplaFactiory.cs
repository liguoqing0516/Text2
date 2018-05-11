using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
  public  class FoodSimplaFactiory
    {
        public static Food CreateFood(string type)
        {
            Food food = null;
            if (type.Equals("土豆丝"))
            {
                food =new  ShreddedPorkWithPotatoes();
            }
            else if (type.Equals("西红柿炒鸡蛋"))
            {
                food = new TomatoScrambledEggs();
            }
            else if (food==null)
            {
                throw new ArgumentNullException(nameof(food));
               
            }
            return food;
        }
    }
}
