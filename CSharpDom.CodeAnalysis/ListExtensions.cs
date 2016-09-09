using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal static class ListExtensions
    {
        public static void ReplaceFirst<T>(this IList<T> list, T newItem)
            where T : class
        {
            if (list.Count == 0)
            {
                if (newItem != null)
                {
                    list.Add(newItem);
                }
            }
            else if (newItem == null)
            {
                list.RemoveAt(0);
            }
            else
            {
                list[0] = newItem;
            }
        }
    }
}
