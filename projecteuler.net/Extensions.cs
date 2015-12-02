using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler.net
{
    static class Extensions
    {
        public static bool IsPrime(this int p)
        {
            for(int i = 2; i <= Math.Sqrt(p); i++)
            {
                if(p % i == 0)
                    return false;
            }
            return true;
        }
    }
}
