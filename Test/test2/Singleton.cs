using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
  public  class Singleton
  {
      private static Singleton singleton;

      public Singleton()
      {
          
      }

      public static Singleton GetSingleton()
      {
          if (singleton==null)
          {
              singleton = new Singleton();
          }

          return singleton;
      }
  }
}
