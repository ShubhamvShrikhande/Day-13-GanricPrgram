using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnric
{
        public class Number<T> where T : IComparable<T>
        {
            private T first_Value;
            private T second_Value;
            private T third_Value;
            public Number(T first_Value, T second_Value, T third_Value)
            {
                this.first_Value = first_Value;
                this.second_Value = second_Value;
                this.third_Value = third_Value;
            }
            public static T GetMaximum(T first_Value, T second_Value, T third_Value)
            {
                if (first_Value.CompareTo(second_Value) > 0 && first_Value.CompareTo(third_Value) > 0)
                {
                    return first_Value;
                }
                else if (second_Value.CompareTo(first_Value) > 0 && second_Value.CompareTo(third_Value) > 0)
                {
                    return second_Value;
                }
                else if (third_Value.CompareTo(first_Value) > 0 && third_Value.CompareTo(second_Value) > 0)
                {
                    return third_Value;
                }
                else
                {
                    throw new Exception("Values are same");
                }

            }

        }
}
