using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnric
{
    public class Number
    {
        public static string MaximumStringNum(string Apple, string Peach, string Banana)
        {
            if (Apple.CompareTo(Peach) > 0 && Apple.CompareTo(Banana) > 0)

            {
                return Apple;
            }
            if (Peach.CompareTo(Apple) > 0 && Peach.CompareTo(Banana) > 0)
            {
                return Peach;
            }
            if (Banana.CompareTo(Apple) > 0 && Banana.CompareTo(Peach) > 0)
            {
                return Banana;
            }
            return Apple;
        }


        
    }
}
