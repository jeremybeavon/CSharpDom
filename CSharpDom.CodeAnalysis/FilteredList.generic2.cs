using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class FilteredList<TParent, TChild> : WrappedList<TParent, TChild>
        where TChild : class, TParent
    {
        public FilteredList(IList<TParent> list, Func<TChild, bool> filter = null)
            : base(list, parent => parent as TChild, child => child, filter)
        {
        }
    }
}
