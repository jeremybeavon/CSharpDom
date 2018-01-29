using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal class FilteredChildSyntaxList<TParentSyntax, TChildBaseSyntax, TChildSyntax> :
        WrappedChildSyntaxList<TParentSyntax, TChildBaseSyntax, TChildSyntax>
        where TChildSyntax : class, TChildBaseSyntax
    {
        public FilteredChildSyntaxList(
            IChildSyntaxList<TParentSyntax, TChildBaseSyntax> list,
            Func<TChildSyntax, bool> filter = null)
            : base(list, parent => parent as TChildSyntax, child => child, filter)
        {
        }
    }
}
