using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal static class ListFactory
    {
        public static IChildSyntaxList<TParentSyntax, TChildSyntax> CreateChildSyntaxList<
            TParent,
            TParentSyntax,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList)
            where TParentSyntax : class
            where TChildSyntax : SyntaxNode
        {
            return CreateChildSyntaxList(node, new ImmutableSyntaxList<TChildSyntax>(), getList, createList);
        }

        public static IChildSyntaxList<TParentSyntax, TChildSyntax> CreateChildSyntaxList<
            TParent,
            TParentSyntax,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList)
            where TParentSyntax : class
            where TChildSyntax : SyntaxNode
        {
            return CreateChildSyntaxList(node, new ImmutableSeparatedSyntaxList<TChildSyntax>(), getList, createList);
        }

        public static IChildSyntaxList<TParentSyntax, TChildSyntax> CreateChildSyntaxList<
            TParent,
            TParentSyntax,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            IChildSyntaxListConversions<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> conversions)
            where TParentSyntax : class
            where TChildSyntax : SyntaxNode
        {
            return CreateChildSyntaxList(node, new ImmutableSeparatedSyntaxList<TChildSyntax>(), conversions);
        }

        public static SyntaxNodeList<TParent, TParentSyntax, TChild, TChildSyntax> CreateNodeList<
            TParent,
            TParentSyntax,
            TChild,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, TChild> factory)
            where TParent : class, IHasNode<TParentSyntax>
            where TParentSyntax : class
            where TChild : class, IHasNode<TChildSyntax>
            where TChildSyntax : SyntaxNode
        {
            return new SyntaxNodeList<TParent, TParentSyntax, TChild, TChildSyntax>(node, getList, createList, factory);
        }

        public static SeparatedSyntaxNodeList<TParent, TParentSyntax, TChild, TChildSyntax> CreateNodeList<
            TParent,
            TParentSyntax,
            TChild,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, TChild> factory)
            where TParent : class, IHasNode<TParentSyntax>
            where TParentSyntax : class
            where TChild : class, IHasNode<TChildSyntax>
            where TChildSyntax : SyntaxNode
        {
            return new SeparatedSyntaxNodeList<TParent, TParentSyntax, TChild, TChildSyntax>(
                node,
                getList,
                createList,
                factory);
        }
        
        public static IChildSyntaxList<TParentSyntax, TChildSyntax> CreateFilteredSyntaxList<
            TParent,
            TParentSyntax,
            TChildBaseSyntax,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildBaseSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildBaseSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, bool> filter)
            where TParentSyntax : class
            where TChildBaseSyntax : SyntaxNode
            where TChildSyntax : TChildBaseSyntax
        {
            return new FilteredChildSyntaxList<TParentSyntax, TChildBaseSyntax, TChildSyntax>(
                CreateChildSyntaxList(node, getList, createList),
                filter);
        }

        public static IList<TChild> CreateFilteredList<TParent, TChild>(IList<TParent> list, Func<TChild, bool> filter)
            where TChild : class, TParent
        {
            return new FilteredList<TParent, TChild>(list, filter);
        }
       
        public static GenericParameterDeclarationSyntaxList<TParent, TParentSyntax> CreateChildSyntaxList<
            TParent,
            TParentSyntax>(
            Node<TParent, TParentSyntax> node,
            TypeParameterSyntaxListConversions<TParentSyntax> typeParameterConversions,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> getConstraintClauses,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>, TParentSyntax> createConstraintClauses)
            where TParentSyntax : class
        {
            return new GenericParameterDeclarationSyntaxList<TParent, TParentSyntax>(
                node,
                typeParameterConversions,
                getConstraintClauses,
                createConstraintClauses);
        }

        private static IChildSyntaxList<TParentSyntax, TChildSyntax> CreateChildSyntaxList<
            TParent,
            TParentSyntax,
            TChildList,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            IImmutableList<TChildList, TChildSyntax> immutableList,
            Func<TParentSyntax, TChildList> getList,
            Func<TParentSyntax, TChildList, TParentSyntax> createList)
            where TParentSyntax : class
            where TChildList : IReadOnlyList<TChildSyntax>
        {
            return new ChildSyntaxList<TParent, TParentSyntax, TChildList, TChildSyntax>(
                node,
                immutableList,
                getList,
                createList);
        }

        private static IChildSyntaxList<TParentSyntax, TChildSyntax> CreateChildSyntaxList<
            TParent,
            TParentSyntax,
            TChildList,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            IImmutableList<TChildList, TChildSyntax> immutableList,
            IChildSyntaxListConversions<TParentSyntax, TChildList> conversions)
            where TParentSyntax : class
            where TChildList : IReadOnlyList<TChildSyntax>
        {
            return new ChildSyntaxList<TParent, TParentSyntax, TChildList, TChildSyntax>(
                node,
                immutableList,
                conversions);
        }
    }
}
