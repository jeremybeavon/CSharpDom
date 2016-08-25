using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal static class ListFactory
    {
        public static IList<TChildSyntax> CreateList<TParentNode, TParentSyntax, TChildList, TChildSyntax>(
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

        public static IList<TChildSyntax> CreateFilteredList<TParentNode, TParentSyntax, TChildBaseClassSyntax, TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildBaseClassSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildBaseClassSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, bool> filter = null)
            where TParentNode : class
            where TParentSyntax : SyntaxNode
            where TChildBaseClassSyntax : SyntaxNode
            where TChildSyntax : TChildBaseClassSyntax
        {
            return new FilteredList<TChildBaseClassSyntax, TChildSyntax>(
                CreateList(node, new ImmutableSyntaxList<TChildBaseClassSyntax>(), getList, createList),
                filter);
        }
    }
}
