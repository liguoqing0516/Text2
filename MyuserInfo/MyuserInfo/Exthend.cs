using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyuserInfo
{
 public  static class Exthend
    {
        public static int Toin(this int ? i)
        {
            return i ?? 0;
        }
    }
}
