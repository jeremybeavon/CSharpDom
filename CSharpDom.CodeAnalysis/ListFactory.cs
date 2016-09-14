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
            Func<TParentSyntax, TypeParameterListSyntax> getTypeParameters,
            Func<TParentSyntax, TypeParameterListSyntax, TParentSyntax> createTypeParameters,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> getConstraintClauses,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>, TParentSyntax> createConstraintClauses)
            where TParentSyntax : class
        {
            return new GenericParameterDeclarationList<TParentNode, TParentSyntax>(
                node,
                syntax => getTypeParameters(syntax).Parameters,
                (parentSyntax, childSyntax) => createTypeParameters(parentSyntax, getTypeParameters(parentSyntax).WithParameters(childSyntax)),
                getConstraintClauses,
                createConstraintClauses);
        }

        public static SyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax> CreateList<
            TParentNode,
            TParentSyntax,
            TChildNode,
            TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, TChildNode> factory)
            where TParentNode : class, IHasSyntax<TParentSyntax>
            where TParentSyntax : class
            where TChildNode : class, IHasNode<TChildSyntax>
            where TChildSyntax : SyntaxNode
        {
            return new SyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax>(node, getList, createList, factory);
        }

        public static SeparatedSyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax> CreateList<
            TParentNode,
            TParentSyntax,
            TChildNode,
            TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, TChildNode> factory)
            where TParentNode : class, IHasSyntax<TParentSyntax>
            where TParentSyntax : class
            where TChildNode : class, IHasNode<TChildSyntax>
            where TChildSyntax : SyntaxNode
        {
            return new SeparatedSyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax>(
                node,
                getList,
                createList,
                factory);
        }

        public static IList<NameSyntax> CreateBaseTypeList<TParentNode, TParentSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, BaseListSyntax, TParentSyntax> createList)
            where TParentSyntax : TypeDeclarationSyntax
        {
            return new BaseTypeList<TParentNode, TParentSyntax>(
                node,
                syntax => syntax.BaseList.Types,
                (parentSyntax, childSyntax) => createList(parentSyntax, parentSyntax.BaseList.WithTypes(childSyntax)));
        }

        public static IList<TChildSyntax> CreateFilteredList<TParentNode, TParentSyntax, TChildBaseSyntax, TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildBaseSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildBaseSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, bool> filter)
            where TParentSyntax : class
            where TChildBaseSyntax : SyntaxNode
            where TChildSyntax : TChildBaseSyntax
        {
            return new FilteredList<TChildBaseSyntax, TChildSyntax>(CreateList(node, getList, createList), filter);
        }
    }
}
