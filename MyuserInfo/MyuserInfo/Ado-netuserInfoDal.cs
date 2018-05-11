using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyuserInfo
{
    public class IuserInfoDal : IUserInfoDal
    {
        public void Show()
        {
            Console.WriteLine("我调用了ado");
        }
    }
}
