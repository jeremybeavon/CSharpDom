using CSharpDom.Common;
using System.Collections.Generic;

namespace CSharpDom
{
    public sealed class NameComparer : IComparer<IHasName>
    {
        public int Compare(IHasName x, IHasName y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
