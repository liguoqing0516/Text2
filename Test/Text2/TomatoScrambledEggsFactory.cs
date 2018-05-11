using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text2
{
    public class TomatoScrambledEggsFactory : Creator
    {
        public override Food CreateFoodFactory()
        {
            return new TomatoScrambledEggs();
        }
    }
}
