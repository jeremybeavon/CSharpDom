using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal static class FilteredListFactory
    {
        public static IList<TChild> Create<TParent, TChild>(
            Func<SyntaxList<TParent>> getList,
            Action<SyntaxList<TParent>> setList,
            Func<TChild, bool> filter)
            where TParent : SyntaxNode
            where TChild : TParent
        {
            return new FilteredList<TParent, TChild>(new ImmutableSyntaxListWrapper<TParent>(getList, setList), filter);
        }
    }
}
