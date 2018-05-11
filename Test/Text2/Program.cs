using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text2
{
   public class Program
    {
        static void Main(string[] args)
        {
            Creator shredPorkWithFactory = new ShreddedPorkWithPotatoesFactory();
            Creator tomatoScrambleFactor = new TomatoScrambledEggsFactory();
            Food tomatEggs = tomatoScrambleFactor.CreateFoodFactory();
            tomatEggs.print();
        }
    }
}
