using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Session1
{
    internal static class IntExtensions
    {
        public static int Reverse(this int num)
        {
            int reversednum = 0, reminder;
            while(num!=0)
            {
                reminder=num % 10;
                reversednum = reversednum * 10 + reminder;
                num /= 10;
            }
            return reversednum;
        }
    }
}
