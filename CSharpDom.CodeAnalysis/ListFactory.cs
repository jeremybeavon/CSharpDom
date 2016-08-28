using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
            return new ImmutableChildListWrapper<TParentNode, TParentSyntax, TChildList, TChildSyntax>(
                node,
                immutableList,
                getList,
                createList);
        }

        public static IList<TChildSyntax> CreateList<TParentNode, TParentSyntax, TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList)
            where TParentSyntax : class
            where TChildSyntax : SyntaxNode
        {
            return CreateList(node, new ImmutableSyntaxList<TChildSyntax>(), getList, createList);
        }

        public static IList<TChildSyntax> CreateList<TParentNode, TParentSyntax, TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList)
            where TParentSyntax : class
            where TChildSyntax : SyntaxNode
        {
            return CreateList(node, new ImmutableSeparatedSyntaxList<TChildSyntax>(), getList, createList);
        }

        public static IList<GenericParameterDeclarationSyntax> CreateList<TParentNode, TParentSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TypeParameterSyntax>> getTypeParameters,
            Func<TParentSyntax, SeparatedSyntaxList<TypeParameterSyntax>, TParentSyntax> createTypeParameters,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> getConstraintClauses,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>, TParentSyntax> createConstraintClauses)
            where TParentSyntax : class
        {
            return new GenericParameterDeclarationList<TParentNode, TParentSyntax>(
                node,
                getTypeParameters,
                createTypeParameters,
                getConstraintClauses,
                createConstraintClauses);
        }
    }
}
