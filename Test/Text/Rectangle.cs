using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    public abstract class Quadranle
    {
        public virtual long Width { get; set; }
        public virtual long Hieigth { get; set; }
    }

    public class Rectangle:Quadranle
    {
        public override long Width { get; set; }
        public override long Hieigth  { get; set; }
    }

    public class Square : Quadranle
    {
        public long _side;

        public Square(long side)
        {
            _side = side;
        }
    }

    class Texts
    {
        public void Resize(Quadranle r)
        {
            while (r.Hieigth >= r.Width)
            {
                r.Width += 1;
            }

            Console.WriteLine(r.Width);
        }

       

    }

}
