using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom
{
    public static class EnumerableExtensions
    {
        public static TOutput[] ToArray<TInput, TOutput>(this IEnumerable<TInput> enumerable, Func<TInput, TOutput> func)
        {
            return enumerable.Select(func).ToArray();
        }

        public static List<TOutput> ToList<TInput, TOutput>(this IEnumerable<TInput> enumerable, Func<TInput, TOutput> func)
        {
            return enumerable.Select(func).ToList();
        }
    }
}
