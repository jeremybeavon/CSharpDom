using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal static class ListFactory
    {
        public static ImmutableChildSyntaxListWrapper<TParentNode, TParentSyntax, TChildList, TChildSyntax>
            CreateList<TParentNode, TParentSyntax, TChildList, TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            IImmutableList<TChildList, TChildSyntax> immutableList,
            Func<TParentSyntax, TChildList> getList,
            Func<TParentSyntax, TChildList, TParentSyntax> createList)
            where TParentSyntax : class
            where TChildList : IReadOnlyList<TChildSyntax>
        {
            return new ImmutableChildSyntaxListWrapper<TParentNode, TParentSyntax, TChildList, TChildSyntax>(
                node,
                immutableList,
                getList,
                createList);
        }
    }
}
