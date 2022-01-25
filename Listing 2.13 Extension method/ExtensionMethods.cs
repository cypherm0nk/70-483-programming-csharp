using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2._13_Extension_method
{
    public static class MyExtensions
    {
        public static int LineCount(this String str)
        {
            return str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
