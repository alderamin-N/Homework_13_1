using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13_1
{
    public static class EnumerableExtension
    {       
        public static IEnumerable<T> Top<T>(this IEnumerable<T> list, int number)
        {
            if (number is < 1 or > 100)
            {
                throw new ArgumentException("Процент был указан меньше 1 или больше 100");
            }            
            var count = (int)Math.Ceiling(list.Count() * (double)number / 100);
            return list.OrderByDescending(x => x).Take(count);

        }
        public static IEnumerable<T> Top<T, P>(this IEnumerable<T> list, int number, Func<T, P> condition)
        {
            if (number is < 1 or > 100)
            {
                throw new ArgumentException("Процент был указан меньше 1 или больше 100");
            }
            var count = (int)Math.Ceiling(list.Count() * (double)number / 100);
            return list.OrderByDescending(condition).Take(count);
        }
    }
}
