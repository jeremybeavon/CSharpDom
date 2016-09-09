using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class FilteredList<T> : WrappedList<T, T>
        where T : class
    {
        public FilteredList(IList<T> list, Func<T, bool> filter = null)
            : base(list, parent => parent, child => child, filter)
        {
        }
    }
}
